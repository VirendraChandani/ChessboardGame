namespace ChessboardGameTests
{
    public class ChessboardGameTests
    {
        [Fact]
        public void WhenPressedTheDownKeyMoveReturnsFalse()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();

            // Act
            bool? result = game.Move("DownArrow");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void WhenPressedTheInvalidKeyMoveReturnsNull()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();

            // Act
            bool? result = game.Move("X");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void WhenWentWinningPathMoveReturnsTrue()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("RightArrow");

            // Act
            bool? result = game.Move("RightArrow");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void WhenWentLosingPathMoveReturnsFalse()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");

            // Act
            bool? result = game.Move("DownArrow");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void WhenInvalidMoveOutsideBoundsReturnsNull()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();

            // Act
            bool? result = game.Move("UpArrow");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void WhenWentWinningPathGetMovesReturnsFourteen()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("RightArrow");
            game.Move("RightArrow");

            // Act
            int result = game.GetMoves();

            // Assert
            Assert.Equal(14, result);
        }

        [Fact]
        public void WhenWentLosingPathGetLivesReturnsZero()
        {
            // Arrange
            IChessboardGame game = new ChessboardGame.ChessboardGame();
            game.Move("RightArrow");
            game.Move("RightArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");
            game.Move("DownArrow");

            // Act
            int result = game.GetLives();

            // Assert
            Assert.Equal(0, result);
        }
    }
}
