using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";
            rolldice();
            menu();



            while (answer == "yes")

            {
                Console.WriteLine("would you like to roll one or two dice? 1 or 2");
                Console.ReadLine();


                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);

                if (choice != 1 || choice != 2)
                {
                    Console.WriteLine("would you like to roll one or two dice? 1 or 2");
                }
            }
        }

        private static void menu(string answer)
        {
            Console.WriteLine("would you like to roll agian?");
            answer = (Console.ReadLine());
        }

        private static void rolldice(int min, int max, )
        {
            Random rnd = new Random();
            
            int rand = rnd.Next(min, max);
        }
    }
}
