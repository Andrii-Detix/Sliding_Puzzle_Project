namespace Sliding_Puzzle_Project;

public class Board
{
   public Board(int size)
    {
        Buttons = new Buttons(size);
        Size = size;
    }

    public Buttons Buttons;
    
    private readonly int Size;
    private const int ButtonHeight = 3;
    private const int ButtonWidth = 5;
    
    public void DrawBoard()
    {
        DrawContours();
        DrawSelectedButton();
        DrawNumbers();
    }
    
   private void DrawContours()
   {
       int rowLimit = Size*ButtonHeight+Size;
       int columnLimit = Size*ButtonWidth+Size;
        for (int i = 0; i <= rowLimit; i++)
        {
            if (i % (ButtonHeight+1) == 0)
            {
                for (int j = 0; j <= columnLimit; j++)
                {
                    Console.Write("#");
                }
            }
            else
            {
                for (int j = 0; j <= columnLimit; j++)
                {
                    
                    if (j % (ButtonWidth+1) == 0)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
   
   private void DrawSelectedButton()
   {
       int currentLeft = Buttons.SelectedButtonColumn * ButtonWidth + Buttons.SelectedButtonColumn+1;
       int currentTop = Buttons.SelectedButtonRow * ButtonHeight + Buttons.SelectedButtonRow+1;
       
        
       Console.ForegroundColor = ConsoleColor.Red;
       for (int i = 0; i < ButtonHeight; i++)
       {
           for (int j = 0; j < ButtonWidth; j++)
           {
               Console.SetCursorPosition(currentLeft,currentTop);
               Console.Write("#");
               currentLeft++;
           }

           currentLeft -= ButtonWidth;
           currentTop++;
       }
       Console.ResetColor();
   }
   
    private void DrawNumbers()
    {
        int currentLeft, currentTop;
        for (int i = 0; i < Size; i++)
        {
            
            currentTop = i*(ButtonHeight+1) + ButtonHeight / 2 + 1;
            
            for (int j = 0; j < Size; j++)
            {
                currentLeft = j*(ButtonWidth+1) + ButtonWidth / 2 + 1;
                
                if (Buttons.ButtonsValue[i, j] == 0) continue;
                Console.SetCursorPosition(currentLeft, currentTop);
                Console.Write(Buttons.ButtonsValue[i,j]);
            }
        }
    }
    
    
}