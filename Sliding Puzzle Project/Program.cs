using Sliding_Puzzle_Project;

int size = Logic.SelectBoardSize();
Board board = new Board(size);

while (!Logic.CheckOrder(ref board.Buttons))
{
    Console.Clear();
    board.DrawBoard();
    Logic.ButtonAction(Console.ReadKey().Key, ref board.Buttons);
}

Console.Clear();
Console.WriteLine("Congratulations! You are winner!");
Console.ReadKey();
