namespace Sliding_Puzzle_Project;

public class Board
{
    public Board(int size)
    {
        Size = size;
    }
    
    private readonly int Size;
    private const int ButtonHeight = 3;
    private const int ButtonWidth = 5;

    public void DrawBoard()
    {
        DrawContours();
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

}