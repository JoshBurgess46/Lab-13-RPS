using System;

namespace Lab13RPS
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Player user = new ThirdPlayer();
            Player opponent;
            Console.WriteLine("Welcome to the Rock, Paper, Scissors World Championship!");
            Console.WriteLine("Please enter your name.");
            user.Name = Console.ReadLine().ToLower();
            bool go = true;
            while (go)
            {

                Console.WriteLine($"{user.Name}, choose your oppenent Jimbo or Grant(j/g)");
                string input = Console.ReadLine().ToLower();

                if (input == "j")
                {
                    opponent = new Jimbo();
                    RoshamboApp.RpsMatch(user, opponent);

                }
                else if (input == "g")
                {
                    opponent = new Grant_Cirpus();
                    RoshamboApp.RpsMatch(user,opponent);
                }

                go = Continue();

            }

        }
        public static bool Continue()
        {
            //will prompt the user if they would like to cont. if not end the program
            Console.WriteLine($"Press {'y'} to continue or press any other key to exit.");
            char response = Console.ReadKey(true).KeyChar;
            if (response == 'y')
            {
                return true;
            }
            else
            {
                //if the user enter 'y' the program will return false and end the program
                //if false it will then display the below text with how many circles they have made.
                Console.WriteLine("Good-Bye");
                return false;
            }
        }
    }
}
