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

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine($"{result}! {DetermineFeedback(userChoice, computerChoice)}");
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

                else if (compChoice == "Scissors")
                {
                    return "Win";
                }

                else if (compChoice == "Lizard")
                {
                    return "win";
                }

                else
                {
                    return "Lose";
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

                else if (compChoice == "Scissors")
                {
                    return "Lose";
                }

                else if (compChoice == "Lizard")
                {
                    return "Lose";
                }

                else
                {
                    return "Win";
                }
            }

            else if (userChoice == "Scissors")
            {
                if (compChoice == "Rock")
                {
                    return "Lose";
                }

                else if (compChoice == "Paper")
                {
                    return "Win";
                }

                else if (compChoice == "Scissors")
                {
                    return "Draw";
                }

                else if (compChoice == "Lizard")
                {
                    return "Win";
                }

                else
                {
                    return "Lose";
                }

            }

            else if (userChoice == "Lizard" )
            {
                if (compChoice == "Rock")
                {
                    return "Lose";
                }

                else if (compChoice == "Paper")
                {
                    return "Win";
                }

                else if (compChoice == "Scissors")
                {
                    return "Lose";
                }

                else if (compChoice == "Lizard")
                {
                    return "Draw";
                }

                else
                {
                    return "Win";
                }
            }

            else 
            {
                if (compChoice == "Rock")
                {
                    return "Win";
                }

                else if (compChoice == "Paper")
                {
                    return "Lose";
                }

                else if (compChoice == "Scissors")
                {
                    return "Win";
                }

                else if (compChoice == "Lizard")
                {
                    return "Lose";
                }

                else
                {
                    return "Draw";
                }
            }

        }

        private static string DetermineFeedback(string userChoice, string compChoice)
        {

            if (userChoice == "Rock")
            {
                if (compChoice == "Rock")
                {
                    return "Rock attacked Rock, both Rock and Rock fainted";
                }

                else if (compChoice == "Paper")
                {
                    return "Paper hugged Rock to oblivion";
                }

                else if (compChoice == "Scissors")
                {
                    return "Rock mangled Scissors after banging repeatedly ";
                }

                else if (compChoice == "Lizard")
                {
                    return "Rock smooshed Lizard into the ground";
                }

                else
                {
                    return "Spock vapourised Rock";
                }
            }

            if (userChoice == "Paper")
            {
                if (compChoice == "Rock")
                {
                    return "Paper hugged Rock to oblivion";
                }

                else if (compChoice == "Paper")
                {
                    return "Paper hugged Paper, it was love";
                }

                else if (compChoice == "Scissors")
                {
                    return "Paper was cut down by Scissors ";
                }

                else if (compChoice == "Lizard")
                {
                    return "Lizard digested Paper";
                }

                else
                {
                    return "Paper disproved Spock. Spock is in de nile";
                }
            }

            else if (userChoice == "Scissors")
            {
                if (compChoice == "Rock")
                {
                    return "Rock mangled Scissors after banging repeatedly";
                }

                else if (compChoice == "Paper")
                {
                    return "Paper was cut down by Scissors";
                }

                else if (compChoice == "Scissors")
                {
                    return "Scissors cut Scissors. Scissors cut Scissors back that about it";
                }

                else if (compChoice == "Lizard")
                {
                    return "Scissors decapited Lizard to get a head";
                }

                else
                {
                    return "Spock broke Scissors";
                }

            }

            else if (userChoice == "Lizard" )
            {
                if (compChoice == "Rock")
                {
                    return "Rock smooshed Lizard into the ground";
                }

                else if (compChoice == "Paper")
                {
                    return "Lizard digested Paper";
                }

                else if (compChoice == "Scissors")
                {
                    return "Scissors decapited Lizard to get a head";
                }

                else if (compChoice == "Lizard")
                {
                    return "Lizard poisoned lizard, Lozard poisoned lizard back they both slowly die ironically";
                }

                else
                {
                    return "Lizard poisoned Spock";
                }
            }

            else 
            {
                if (compChoice == "Rock")
                {
                    return "Spock vapourised Rock";
                }

                else if (compChoice == "Paper")
                {
                    return "Paper disproved Spock. Spock is in de nile ";
                }

                else if (compChoice == "Scissors")
                {
                    return "Spock broke Scissors";
                }

                else if (compChoice == "Lizard")
                {
                    return "Lizard poisoned Spock";
                }

                else
                {
                    return "Spock argues with Spock, each are stubbon and argue until you get bored and left";
                }
            }

        }

        private static string compTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 6);

            if (choice == 1)
            {
                return "Rock";
            }

            else if (choice == 2)
            {
                return "Paper";
            }

            else if (choice == 3)
            {
                return "Scissors";
            }

            else if (choice == 4)
            {
                return "Lizard";
            }

            else
            {
                return "Spock";
            }
        }

        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Lizard");
                Console.WriteLine("5. Spock");
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

            else if (choice == "3")
            {
                return "Scissors";
            }

            else if (choice == "4")
            {
                return "Lizard";
            }

            else
            {
                return "spock";
            }
        }

        private static void PrintScore(ref int userScore, ref int compScore)
        {
            Console.Clear();
            Console.WriteLine($"User Score: {userScore} \t\t computerscore: {compScore}");
        }
    }
}
