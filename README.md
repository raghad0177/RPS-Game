# Lab4
# Rock-Paper-Scissors Game

This project implements a console-based Rock-Paper-Scissors game in C#. The game allows a single player to compete against an AI opponent, with functionality to handle game logic, track scores, and determine the winner of each round. The project also includes unit tests to verify the correctness of the game logic.

## Game Functionality

1. The player and AI take turns choosing their moves (rock, paper, or scissors).
2. The game compares the moves of both players and determines the winner of each round.
3. After each round, the game displays the result and updates the scores.
4. The game continues until 3 rounds have been played or until a player reaches 3 points.
5. The final scores are displayed, and the winner is declared.

## Exception Handling

- The game prevents the player from choosing an invalid move.
- Handles any exceptions that might occur during gameplay to ensure a smooth gaming experience.

## Unit Tests

The project includes unit tests written using Xunit to verify the following:

1. The game correctly determines the winner of each round based on the players' moves.
2. The game correctly updates the scores after each round.

## Stretch Goals

- **Hard Mode**: Implement a cheat method that allows the AI to predict the player's move, providing an unfair advantage to the AI. This method is used for demonstration purposes only.

## Usage

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build the solution to restore dependencies.
4. Run the application to start playing the game.
5. To run the unit tests, open the Test Explorer in Visual Studio and run all tests.

## Conclusion

This Rock-Paper-Scissors game provides a fun and interactive way to play against an AI opponent. The code is well-structured, with clear separation of concerns between game logic, player interactions, and the main program entry point. The unit tests ensure the correctness of the game logic and provide confidence in the functionality of the application.