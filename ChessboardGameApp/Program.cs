namespace ChessboardGameApp
{
    class Program
    {
        private readonly IChessboardGame game;

        public Program(IChessboardGame game)
        {
            this.game = game;
        }

        static void Main()
        {
            IChessboardGame game = new ChessboardGame.ChessboardGame();
            Program program = new Program(game);
            program.Run();
        }

        private void DisplayInstructions()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Chessboard Game!");
            Console.WriteLine("You are starting at position A1. Avoid the mines (M) and reach H8 to win.");
            Console.WriteLine("You have 3 lives. Press escape key to quit the game.");
            Console.WriteLine();
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Use arrow keys to move (up, down, left, right).");
            Console.WriteLine("2. Press escape key to quit the game.");
            Console.WriteLine();
        }

        private void Run()
        {
            DisplayInstructions();

            while (true)
            {
                Console.WriteLine($"Position: {game.GetGameStatus()}");
                Console.WriteLine($"Moves: {game.GetMoves()}");
                Console.WriteLine($"Lives left: {game.GetLives()}");
                game.DisplayChessboard();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without echoing to the console

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Game over. You quit.");
                    Console.ReadLine();
                    break;
                }

                string direction = ConvertKeyToDirection(keyInfo.Key);

                if (direction != null)
                {
                    if (game.Move(direction) == true)
                    {
                        Console.WriteLine("Congratulations! You reached H8 and won the game!");
                        Console.ReadLine();
                        break;
                    }
                    if (game.GetLives() == 0)
                    {
                        Console.WriteLine("Sorry! You have lost all your lives!");
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Use arrow keys to move.");
                }
            }
        }

        private string ConvertKeyToDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    return "UpArrow";
                case ConsoleKey.DownArrow:
                    return "DownArrow";
                case ConsoleKey.LeftArrow:
                    return "LeftArrow";
                case ConsoleKey.RightArrow:
                    return "RightArrow";
                default:
                    return null; // Invalid key
            }
        }
    }
}
