namespace Sliding_Puzzle_Project;

public struct Buttons
{
  
    public Buttons(int size)
    {
        Size = size;
        CreateButtons();
    }

    public readonly int Size;
    
    public int[,] ButtonsValue { get; private set; }
    public int SelectedButtonColumn { get; set; } = 0;
    public int SelectedButtonRow { get; set; }= 0;
    
    private void CreateButtons()
    {
        
        ButtonsValue = new int[Size, Size];
        Random random = new Random();
        int maxValue = Size * Size;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                while (CheckButtonRepeat(i, j))
                {
                    ButtonsValue[i, j] = random.Next(0, maxValue);
                }
            }
        }
    }

    private bool CheckButtonRepeat(int currentButtonRow, int currentButtonColumn)
    {
        bool isRepeat = false;
        for (int i = 0; i <= currentButtonRow; i++)
        {
            int iterationsLimit = (i == currentButtonRow ? currentButtonColumn : Size);
            
            for (int j = 0; j < iterationsLimit; j++)
            {
                if (ButtonsValue[i,j] == ButtonsValue[currentButtonRow,currentButtonColumn])
                {
                    isRepeat = true;
                    break;
                }
            }
            if (isRepeat)
                break;
        }

        return isRepeat;
    }
    
}
