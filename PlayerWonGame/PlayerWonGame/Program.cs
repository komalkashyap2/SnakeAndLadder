using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerWonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1RandomNum;
            int player2RandomNum;

            int player1Points = 0;
            int player2Points = 0;

            Random random = new Random();

            // Loop 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice."); // Displays message asking player to press any key

                Console.ReadKey(); // Waits for the player to press any key before generating number

                player1RandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for player
                Console.WriteLine("You rolled a " + player1RandomNum); // Prints out player's randomly generated number

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // Waits one second

                player2RandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for enemy
                Console.WriteLine("Enemy AI rolled a " + player2RandomNum); // Prints out player2`s randomly generated number

                // If the player rolls higher than player2
                if (player1RandomNum > player2RandomNum)
                {
                    player1Points++; // Increase player points
                    Console.WriteLine("Player wins this round!"); // Display message saying player has won this round
                }
                else if (player1RandomNum < player2RandomNum) // If the enemy rolls higher than player
                {
                    player2Points++; // Increase enemy points
                    Console.WriteLine("Enemy wins this round!"); // Display message saying player2 has won this round
                }
                else // If player1 and player2 have rolled the same number
                {
                    Console.WriteLine("Draw!"); // Display message saying this round is a draw
                }

                // Displays player1 and player2 scores
                Console.WriteLine("The score is now - Player1 : " + player1Points + ". Player2 : " + player2Points + ".");
                Console.WriteLine(); // Creates an empty line in between each round
            }

            // If the player1 has scored higher than player2
            if (player1Points > player2Points)
            {
                Console.WriteLine("You win!"); // Display a message saying player wins
            }
            else if (player1Points < player2Points) // If the player2 has scored higher than player1
            {
                Console.WriteLine("You lose!"); // Display message saying player1 loses
            }
            else // If player1 and player2 score the same amount of points
            {
                Console.WriteLine("It's a draw!"); // Display message saying it's a draw
            }

            Console.ReadKey(); // Wait for user input before console window closes
        }
    }
}
