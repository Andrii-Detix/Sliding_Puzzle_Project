namespace Sliding_Puzzle_Project;

static class Logic
{
    public static void ButtonAction(ConsoleKey key, Buttons buttons)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                if (buttons.SelectedButtonRow - 1 >= 0)
                    buttons.SelectedButtonRow--;
                break;

            case ConsoleKey.S:
            case ConsoleKey.DownArrow:
                if (buttons.SelectedButtonRow + 1 < buttons.Size)
                    buttons.SelectedButtonRow++;
                break;

            case ConsoleKey.A:
            case ConsoleKey.LeftArrow:
                if (buttons.SelectedButtonColumn - 1 >= 0)
                    buttons.SelectedButtonColumn--;
                break;

            case ConsoleKey.D:
            case ConsoleKey.RightArrow:
                if (buttons.SelectedButtonColumn + 1 < buttons.Size)
                    buttons.SelectedButtonColumn++;
                break;
            
            case ConsoleKey.F:
            case ConsoleKey.Enter:
                ButtonsRearrange(buttons);
                break;

        }
    }
    
    public static bool CheckOrder(Buttons buttons)
    {
        int previousValue, currentValue;
        previousValue = -1;
        bool isCorrectOrder = true;
        for (int i = 0; i < buttons.Size; i++)
        {
            for (int j = 0; j < buttons.Size; j++)
            {
                currentValue = buttons.ButtonsValue[i, j];
                if (j == i && j == buttons.Size - 1 && currentValue == 0)
                    continue;

                if (previousValue > currentValue || currentValue == 0)
                {
                    isCorrectOrder = false;
                    break;
                }

                previousValue = currentValue;
            }

            if (!isCorrectOrder)
                break;
        }

        return isCorrectOrder;
    }
    
    public static int SelectBoardSize()
    {
        int size;
        do
        {
            Console.Clear();
            Console.Write("""
                          Select the board size:
                          4*4 (Write 4)
                          5*5 (Write 5)
                          Size:
                          """);
            size = int.Parse(Console.ReadLine());
        } while (size != 4 && size != 5);

        return size;

    }

    private static void ButtonsRearrange(Buttons buttons)
    {
        //additional variables x and y so that the code is not stretched and is more readable
        int x = buttons.SelectedButtonColumn;
        int y = buttons.SelectedButtonRow;
        
        if ((x - 1 >= 0) && (buttons.ButtonsValue[y, x - 1] == 0))
        {
            buttons.ButtonsValue[y, x - 1] = buttons.ButtonsValue[y, x];
            buttons.ButtonsValue[y, x] = 0;
        }
        else if ((x + 1 < buttons.Size) && (buttons.ButtonsValue[y, x + 1] == 0))
        {
            buttons.ButtonsValue[y, x + 1] = buttons.ButtonsValue[y, x];
            buttons.ButtonsValue[y, x] = 0;
        }
        else if ((y - 1 >= 0) && (buttons.ButtonsValue[y - 1, x] == 0))
        {
            buttons.ButtonsValue[y - 1, x] = buttons.ButtonsValue[y, x];
            buttons.ButtonsValue[y, x] = 0;
        }
        else if ((y + 1 < buttons.Size) && (buttons.ButtonsValue[y + 1, x] == 0))
        {
            buttons.ButtonsValue[y + 1, x] = buttons.ButtonsValue[y, x];
            buttons.ButtonsValue[y, x] = 0;
        }
    }

}