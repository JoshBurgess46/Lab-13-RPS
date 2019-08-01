using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class ThirdPlayer : Player
    {
        public ThirdPlayer()
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            //Enum.GetName(typeof(Roshambo), ValueOfRo);
            Console.WriteLine("Choose your throw!");
            Console.WriteLine("1. rock " +
                "2. paper " +
                "3. scissors");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "rock" || userInput == "1")
            {
                return Roshambo.Rock;
                //RoshamboApp.RpsMatch(user,opponent);
            }
            else if (userInput == "paper" || userInput == "2")
            {
                return Roshambo.Paper;

            }
            else if (userInput == "scissors" || userInput == "3")
            {
                //Console.WriteLine("scissors");
                return Roshambo.Scissors;

            }
            else
            {
                return GenerateRoshambo();
            }
            //return ValueOfRo;
        }


    }
}

