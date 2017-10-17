using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pick_a_door
{
    class Program
    {
        static void Main(string[] args)
        {

            //input


            Console.WriteLine("Pick a door 1 , 2 , or 3");
            string selection = Console.ReadLine();

            //output


            if (selection == "1")
            {
                Console.WriteLine("behind door 1 is a didgerdildo ");
            }
            else if (selection == "2")
            {
                Console.WriteLine("behind door 2 is asscancer you have been infected");
            }
            else if (selection == "3")
            {
                Console.WriteLine("behind door 3 is the coopers dignity. He lost it a while ago.");
            }
            else
            {
                Console.WriteLine("that aint a door bitch");
            }


            //wait at end
            Console.ReadLine();
        }
    }
}
