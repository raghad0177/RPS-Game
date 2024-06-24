using RPS;

namespace RPSGameTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rock", "paper", "AI")]
        [InlineData("scissors", "rock", "AI")]
        [InlineData("paper", "scissors", "AI")]
        public void TestRoundWinner(string player1, string player2, string expectedWinner)
        {
            // Arrange
            Player playerA = new Player("Ibrahim");
            Player playerB = new Player("AI");

            // Act
             RPSGame.CompareMoves(player1, player2, playerA, playerB);

            // Assert
            Assert.Equal(expectedWinner, playerB.Name);
        }



        [Theory]
        [InlineData("rock", "paper", 1)]
        [InlineData("scissors", "rock", 1)]
        [InlineData("paper", "scissors", 1)]
        public void TestRoundScore(string player1, string player2, int expectedScore)
        {
            // Arrange
            Player playerA = new Player(player1);
            Player playerB = new Player(player2);

            // Act
            RPSGame.CompareMoves(player1, player2, playerA, playerB);

            // Assert
            Assert.Equal(expectedScore, playerB.Score);
        }

    }
}