using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string answer = "yes";
            

            

            while (answer == "yes")
            {
                //Random Number Generator

                int min = 0;
                int max = 1;

                Console.WriteLine("Enter minimum number:");
                min = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter maximum number:");
                max = int.Parse(Console.ReadLine());

                Random rnd = new Random();
                int rand = rnd.Next(min, max);


                //Set Guess Number oOut Of Range

                int guess = -1;


                //Set loop

                int count = 0;

                while (guess != rand)
                {
                    count++;
                    Console.Write("guess my number: ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess < rand)
                    {
                        Console.WriteLine("Too LOW!");
                    }

                    else if (guess > rand)
                    {
                        Console.WriteLine("Too High!");
                    }

                    else
                    {
                        Console.WriteLine($" {guess} is correct it took you {count} attempts");
                    }

                    Console.WriteLine("would you like to play agian?");
                    answer = (Console.ReadLine());

                }

            }

            Console.WriteLine("thanks for playing");


            // wait at end

            Console.ReadKey();

        }
    }
}
