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
        }
    }

}