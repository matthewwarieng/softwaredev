using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // input


            Console.WriteLine("ENTER number:");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            int num= int.Parse(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Black;

            //OUTPUT

            for (int x = 1; x <= num; x++) 
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("");
            Console.WriteLine("press enter to see while:");
            Console.ReadLine();

            int num2 = 1;

            while (num2 <= 10)
            {
                Console.WriteLine(num2);
                num2 ++;
            }


            //wait at end

            Console.ReadKey();

        }
    }
}
