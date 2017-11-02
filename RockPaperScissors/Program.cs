using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops

            int userScore = 0;
            int compScore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref compScore);
                string userChoice = UserTurn();
                string compChoice = compTurn();
                result = DetermineWinner(userChoice, compChoice);
                GiveFeedback(result, userChoice, compChoice);
                UpdateScores(result, ref userScore, ref compScore);
                repeat = PlayAgain();
            }
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("would you like to play again? \nyes or no");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes" || choice == "y")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private static void UpdateScores(string result, ref int userScore, ref int compScore)
        {
            if (result == "Win")
            {
                userScore++;
            }

            else if (result == "Lose")
            {
                compScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, object computerChoice)
        {
            Console.WriteLine($"{result}! you chose {userChoice} and the computer chose {computerChoice}!");
        }

        private static string DetermineWinner(string userChoice, string compChoice)
        {
            if (userChoice == "Rock")
            {
                if (compChoice == "Rock")
                {
                    return "Draw";
                }

                else if (compChoice == "Paper")
                {
                    return "Lose";
                }

                else 
                {
                    return "Win";
                }
            }

            else if (userChoice == "Paper")
            {
                if (compChoice == "Rock")
                {
                    return "Win";
                }

                else if (compChoice == "Paper")
                {
                    return "Draw";
                }

                else 
                {
                    return "Lose";
                }
            }

            else
            {
                if (compChoice == "Rock")
                {
                    return "Lose";
                }

                else if (compChoice == "Paper")
                {
                    return "Win";
                }

                else 
                {
                    return "Draw";
                }
            }

        }

        private static string compTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            if (choice == 1)
            {
                return "Rock";
            }

            else if (choice == 2)
            {
                return "Paper";
            }

            else
            {
                return "Scissors";
            }
        }

        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3.Scissors");
                Console.WriteLine("your choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }

            else if (choice == "2")
            {
                return "paper";
            }

            else
            {
                return "Scissors";
            }
        }

        private static void PrintScore(ref int userScore, ref int compScore)
        {
            Console.Clear();
            Console.WriteLine($"User Score: {userScore} \t\t computerscore: {compScore}");
        }
    }
}
