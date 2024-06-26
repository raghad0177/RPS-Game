﻿namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player playerOne = new Player("Alice");
                Player playerTwo = new Player("AI");
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine($"Round {i}:");
                    RPSGame.CompareMoves(playerOne.ChooseMove(), RPSGame.AIMoves(), playerOne, playerTwo);
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("The Game Finished.");
            }
        }
    }
}
  
