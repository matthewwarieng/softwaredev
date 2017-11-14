using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;            
            playGame(ref money);

        }

        private static void playGame(ref float money)
        {
            int wins = 0;
            for (int i = 1; i <= 362880; i++)
            {
                Console.Clear();
                float betAmount = 0;
                Random rnd = new Random();
                int playerTotal = DealCards(rnd, "You");
                int dealerTotal = DealCards(rnd, "The Dealer");
                bool PlayerWins = determineWinner(playerTotal, dealerTotal, betAmount);
                if (PlayerWins) wins++;
                PayOut(PlayerWins, betAmount, ref money);
            }

            float percentage = (float)wins / (float)362880;
            Console.WriteLine($"player wins {percentage * 100}% of the time");
            Console.ReadKey();
            //menu(ref money, count);
        }

        private static void menu(ref float money)
        {
            //Console.WriteLine("Would you like to play another game? yes/no; ");
            //string choice = Console.ReadLine();
            //if (choice == "y" || choice == "yes")
            //{
                playGame(ref money);
            //}
        }

        private static void PayOut(bool playerWins, float betAmount, ref float money)
        {
            if (playerWins)
            {
                money = money + (betAmount * 2);
            }
        }

        private static bool determineWinner(int playerTotal, int dealerTotal, float betAmount)
        {
            //System.Threading.Thread.Sleep(750);

            if (playerTotal > dealerTotal)
            {
                //Console.WriteLine($"You Won ${betAmount * 2}");
                return true;
            }

            else if (playerTotal < dealerTotal)
            {
                //Console.WriteLine($"You Lost ${betAmount * 2}");
                return false;
            }

            else
            {
                //Console.WriteLine("Its a Draw, Dealers favor, Dealer Wins. ");
                return false;
            }
        }

        private static int DealCards(Random rnd, string Player)
        {
            //Console.Write("dealing cards");
            //System.Threading.Thread.Sleep(750);
            //Console.Write(".");
            //System.Threading.Thread.Sleep(750);
            //Console.Write(".");
            //System.Threading.Thread.Sleep(750);
            //Console.Write(".");

            //Console.WriteLine("");

            int Card1 = rnd.Next(1, 11);
            int Card2 = rnd.Next(1, 11);
            int Total = Card1 + Card2;
            //Console.WriteLine($"{Player} drew {Card1} and {Card2} making a total of {Total} ");
            return Total;
        }

        private static float MakeBet(ref float money)
        {
            float betAmount = 0;
            bool validBet = false;
           // Console.WriteLine($"Enter your bet. You currently have ${money}");
            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > money)
                {
                   // Console.WriteLine($"sorry you do not have enough money to make this bet. You only have {money}, please try again.");
                    validBet = false;
                }

                else if (betAmount < 0)
                {
                    //Console.WriteLine("Bet can not be a negative number, Please try again.");
                    validBet = false;
                }
            }

            money = money - betAmount;
            return betAmount;
        }
    }
}
