using Sliding_Puzzle_Project;

int size = int.Parse(Console.ReadLine());
Board board = new Board(size);

while (true)
{
    Console.Clear();
    board.DrawBoard();
    Logic.ButtonAction(Console.ReadKey().Key, board.Buttons);
}