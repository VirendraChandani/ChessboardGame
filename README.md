# ChessboardGame
Developer Coding Test – Minefield Game

1 The Test
Set aside 2 hours to create some code that shows how you would code a minefield/minesweeper style game
running on the command line (no UI), in order to demonstrate how you would code &amp; test a real-world application
using established best practices.
In the game a player navigates from one side of a chessboard grid to the other whilst trying to avoid hidden mines.
The player has a number of lives, losing one each time a mine is hit, and the final score is the number of moves taken
in order to reach the other side of the board. The command line / console interface should be simple, allowing the
player to input move direction (up, down, left, right) and the game to show the resulting position (e.g. C2 in chess
board terminology) along with number of lives left and number of moves taken.

Above all else please follow these guidelines
1. Quality is more important than quantity
2. We will assess your ability to write clean-code that has good structure &amp; is covered by meaningful tests
3. Don’t code a UI

For simplicity, I have done the display board with visible mines and hard coded for the ease, but it can be hidden and randomize as well

Created 3 projects
1) ChessboardGameApp - Console Application to capture user input and display instructions
2) ChessboardGame - Class Library project to hide the code logic and maintain business logic in separate project
3) ChessboardGameTests - Unit test project to test the game
