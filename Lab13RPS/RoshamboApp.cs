using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class RoshamboApp
    {
        
        public static void RpsMatch(Player user, Player opponent)
        {
            Roshambo userChoice =  user.GenerateRoshambo();
            Roshambo npcChoice = opponent.GenerateRoshambo();
            if (userChoice == npcChoice)
            {
                Console.WriteLine("tied!"); 
            }
            else if ((userChoice == Roshambo.Rock && npcChoice == Roshambo.Scissors)|| (userChoice == Roshambo.Paper && npcChoice == Roshambo.Rock)|| (userChoice == Roshambo.Scissors && npcChoice == Roshambo.Paper))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose...");
            }
        }
    }
}
