using Sliding_Puzzle_Project;

int size = Logic.SelectBoardSize();
Board board = new Board(size);

while (!Logic.CheckOrder(board.Buttons))
{
    Console.Clear();
    board.DrawBoard();
    Logic.ButtonAction(Console.ReadKey().Key, board.Buttons);
}

Console.Clear();
Console.WriteLine("Congratulations! You are winner!");
Console.ReadKey();
