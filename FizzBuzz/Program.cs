using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 to 100

            for (int i = 1; i <= 100; i++)
            {

                //loop

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("FizzBuzz");
                    Console.Beep(3000, 250);
                }

                else if (i == 69)
                {
                    Console.WriteLine("might need some mouth wash");
                }

                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Fizz");
                    Console.Beep(2500, 200);
                }

                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("BUzz");
                    Console.Beep(3500, 100);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{i}");
                    Console.Beep(1000, 100);
                }

            }


            //wait at end

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\npress any key to exit");
            Console.ReadKey();

        }
    }
}
