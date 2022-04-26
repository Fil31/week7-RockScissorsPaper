using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - камень
            //2 - ножницы
            //3 - бумага
            int userScore = 0;
            int cpuScore = 0;
            Console.WriteLine("RockScissorsPaper");
            Console.WriteLine("plays up to 3 points");
            Console.WriteLine("Your choice:");
            while (userScore < 3 && cpuScore < 3)
            {
                Console.WriteLine("Rock - Paper - Scissors");
                string userChoice = Console.ReadLine().ToLower();
                Console.WriteLine($"USER choice {userChoice}");
                Random rnd = new Random();
                int random = rnd.Next(1, 4);
                string cpuChoice = "";
                switch (random)
                {
                    case 1:
                        cpuChoice = "paper";
                        break;
                    case 2:
                        cpuChoice = "rock";
                        break;
                    case 3:
                        cpuChoice = "scissors";
                        break;
                }
                Console.WriteLine($"CPU choice {cpuChoice}");
                if ((cpuChoice == "paper" && userChoice == "rock") || (cpuChoice == "scissors" && userChoice == "paper") || (cpuChoice == "rock" && userChoice == "scissors"))
                {
                    cpuScore++;
                    Console.WriteLine("CPU win! User lose.");
                }
                else if ((userChoice == "rock" && cpuChoice == "scissors") || (userChoice == "paper" && cpuChoice == "rock") || (userChoice == "scissors" && cpuChoice == "paper"))
                {
                    userScore++;
                    Console.WriteLine("USER win! CPU lose.");
                }
                else if (userChoice == cpuChoice)
                {
                    Console.WriteLine("Draw.");
                }
                else
                {
                    cpuScore++;
                    Console.WriteLine("Invalid input from user, CPU wins.");
                }

                Console.WriteLine($"USER score: {userScore} - CPU score: {cpuScore}");

            }
            if (userScore == 3)
            {
                userScore++;
                Console.WriteLine("User Wins");

            }
            else
            {
                cpuScore++;
                Console.WriteLine("Cpu Wins");

            }
            Console.WriteLine("Have a good day!");
        }
    }
}