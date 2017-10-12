using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome_message
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter last name:");
            string lastname = Console.ReadLine();
            Console.Write("enter first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine($"Welcome to the program {firstname} {lastname}");




            //wait at end
            Console.ReadKey();
        }
    }
}
