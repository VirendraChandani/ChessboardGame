public interface IChessboardGame
{
    bool? Move(string direction);
    int GetMoves();
    int GetLives();
    string GetGameStatus();
    void DisplayChessboard();
}
