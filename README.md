# Tic-Tac-Toe

This is a basic console-based Tic-Tac-Toe game implemented in C# as a practice while working on a C# certification course. The game allows two players to play against each other on the same machine.

## Features

- **Two Players**: Players alternate turns to make a move.
- **Game Board**: A 3x3 grid where players can place their markers.
- **Win Check**: Automatically checks for a winner after each move.
- **Draw Detection**: Detects if the game ends in a draw.
- **Game Reset**: Option to restart the game after a win or draw.

## How to Run

1. **Compile and Run**: Open the solution in a C# compatible IDE (e.g., Visual Studio). Build and run the project.
2. **Play**: Follow the on-screen prompts to choose a spot on the board. The board updates after each move, and you will be notified of the game’s outcome.

## Code Overview

- **`Main` Method**: Manages the game loop, player turns, and game state.
- **`GetValidMove` Method**: Prompts the player for a move and ensures it is valid.
- **`MakePlay` Method**: Updates the board with the player's move.
- **`CheckWin` Method**: Checks for a winning condition or a draw.
- **`ResetField` Method**: Resets the game board for a new game.

## Notes

- The board is displayed in the console with positions numbered from 0 to 8.
- The game handles invalid inputs and ensures moves are made in empty spots.

## Contact

For questions or feedback, please contact me at [josh19peter96@gmail.com](mailto:josh19peter9696@gmail.com).
