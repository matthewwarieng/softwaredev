using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //random

            Random rnd = new Random();
            
            //name

            string name = GetName();

            //generate insult

            string Thinking = "Processing"; 
            GenerateInsult(name, rnd, Thinking);
        }

        private static void GenerateInsult(string name, Random rnd, string Thinking)
        {
            System.Threading.Thread.Sleep(1000);
            Random rnd2 = new Random();
            Console.Write( Thinking );
            System.Threading.Thread.Sleep(rnd2.Next(500, 2000));
            Console.Write(".");
            System.Threading.Thread.Sleep(rnd2.Next(500, 2000));
            Console.Write(".");
            System.Threading.Thread.Sleep(rnd2.Next(500, 2000));
            Console.Write(".");
            System.Threading.Thread.Sleep(rnd2.Next(500, 2000));
            Console.Write(".");
            Console.WriteLine("");

            Console.WriteLine($"{name} , you are {GetAdjective(rnd)} {GetCompoundAdjective(rnd)}  {GetObject(rnd)}");
            Menu(name, rnd, Thinking);
        }

        private static void Menu(string name, Random rnd, string Thinking)
        {
            Console.WriteLine("\nWould you like another insult? yes or no?");
            if (Console.ReadLine() == "yes" || Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd, Thinking);
            }
        }

        private static string GetObject(Random rnd)
        {
            string[] Object = { "crab", "stormtrooper", "twuuuurtle", "nugget"};
            return Object[rnd.Next(4)];
        }

        private static string GetCompoundAdjective(Random rnd)
        {
            string[] CompoundAdjective = { "Trump-loving ", "monkey-shite", "fresh moist ", "foul-mouthed" };
            return CompoundAdjective[rnd.Next(4)];
        }

        private static string GetAdjective(Random rnd)
        {
            string[] Adjective = { "a large", "an asshole of a", " a nasty", "a Lame", "such a" };
            return Adjective[rnd.Next(5)];
        }

        private static string GetName()
        {
            Console.WriteLine("Hello, Welcome to the Insult Generator. What is your Name?");
            return Console.ReadLine();

        }
    }
}
