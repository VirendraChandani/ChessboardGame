namespace ChessboardGame
{
    public class ChessboardGame : IChessboardGame
    {
        private char[,] chessboard;
        private int playerRow;
        private int playerCol;
        private int lives;
        private int moves;

        public ChessboardGame()
        {
            InitializeChessboard();
            playerRow = 0;
            playerCol = 0;
            lives = 3;
            moves = 0;
        }

        public bool? Move(string direction)
        {
            int newRow = playerRow;
            int newCol = playerCol;

            switch (direction)
            {
                case "UpArrow":
                    newRow--;
                    break;
                case "DownArrow":
                    newRow++;
                    break;
                case "LeftArrow":
                    newCol--;
                    break;
                case "RightArrow":
                    newCol++;
                    break;
                default:
                    return null; // Invalid move
            }

            if (IsWithinBounds(newRow, newCol))
            {
                char newPosition = chessboard[newRow, newCol];

                if (newPosition == 'M')
                {
                    lives--;
                }
                else
                {
                    chessboard[playerRow, playerCol] = '-';
                    playerRow = newRow;
                    playerCol = newCol;
                    moves++;
                }

                return playerRow == 7 && playerCol == 7; // Check if the player won
            }
            else
            {
                return null; // Invalid move
            }
        }

        public string GetGameStatus()
        {
            return ConvertToChessNotation(playerRow, playerCol);
        }

        public int GetMoves()
        {
            return moves;
        }

        public int GetLives()
        {
            return lives;
        }

        public void DisplayChessboard()
        {
            Console.WriteLine("   A B C D E F G H");

            for (int row = 0; row < 8; row++)
            {
                Console.Write($"{row + 1}  ");
                for (int col = 0; col < 8; col++)
                {
                    if (row == playerRow && col == playerCol)
                    {
                        Console.Write("P ");
                    }
                    else
                    {
                        Console.Write(chessboard[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void InitializeChessboard()
        {
            chessboard = new char[8, 8];

            // Initialize chessboard with mines ('M') and player starting position ('A1')
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    chessboard[row, col] = '-';
                }
            }
            chessboard[0, 0] = 'A';

            // Place mines (M) on the chessboard (customize as needed)
            chessboard[2, 2] = 'M';
            chessboard[4, 4] = 'M';
            chessboard[6, 6] = 'M';
        }

        private bool IsWithinBounds(int row, int col)
        {
            return row >= 0 && row < 8 && col >= 0 && col < 8;
        }

        private string ConvertToChessNotation(int row, int col)
        {
            char letter = (char)('A' + col);
            int number = row + 1;
            return $"{letter}{number}";
        }
    }
}
