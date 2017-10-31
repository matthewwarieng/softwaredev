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
            if (result == "win")
            {
                userScore++;
            }

            else if (result == "lose")
            {
                compScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, object computerChoice)
        {
            
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
                    return "win";
                }
            }

            else if (userChoice == "Paper")
            {
                if (compChoice == "Rock")
                {
                    return "win";
                }

                else if (compChoice == "Paper")
                {
                    return "draw";
                }

                else 
                {
                    return "lose";
                }
            }

            else if (userChoice == "Scissors")
            {
                if (compChoice == "Rock")
                {
                    return "lose";
                }

                else if (compChoice == "Paper")
                {
                    return "win";
                }

                else 
                {
                    return "draw";
                }
            }

        }

        private static string compTurn()
        {
            
        }

        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                choice = Console.ReadLine();
            }
        }

        private static void PrintScore(ref int userScore, ref int compScore)
        {
            Console.Clear();
            Console.WriteLine($"User Score:{userScore} \t\t {compScore}");
        }
    }
}
