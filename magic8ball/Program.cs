using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic8ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playgame(); 
        }

        private static void playgame()
        {
            //array of answers

            string[] answers = { "maybe", "yes", "no", "fo Shizzle", "helll nah", "Not for you botch", "yas ma duuude", "nibba you whiling", "sit back down", };

            //OUTPUT

            Console.WriteLine("Ask me a question that can be answered with a 'yes', 'no' or 'maybe' answer. Type 'exit' to leave ");

            //exit game

            if (Console.ReadLine() != "exit")
            {
                //random answer

                Random rnd = new Random();

                //thinking

                thinking();
                

                //print answer

                Console.WriteLine(answers[rnd.Next(9)]);

                //playgame again

                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                Console.WriteLine("would you like to ask another question?");

                string playagain = ( Console.ReadLine());
                if ( playagain == "'yes" || "y")
                {
                    playgame();
                }
            }
        }

        private static void thinking()
        {
            string[] thinking = { "proccessing", "stupid ass question give me a second", "face palming please wait", "ugh really?", "thinking", };
            Random rnd = new Random();
            Console.Write(thinking[rnd.Next(5)]);
            System.Threading.Thread.Sleep(rnd.Next(500, 2000));
            Console.Write(".");
            System.Threading.Thread.Sleep(rnd.Next(500, 2000));
            Console.Write(".");
            System.Threading.Thread.Sleep(rnd.Next(500, 2000));
            Console.Write(".");
            System.Threading.Thread.Sleep(rnd.Next(500, 2000));
            Console.Write(".");
            Console.WriteLine("");


        }
    }
}
