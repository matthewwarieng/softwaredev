using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "yes";
            while (choice != "no")
            {
                //menu

                Console.Clear();
                Console.WriteLine("choose a shape:");
                Console.WriteLine(" 1. rectangle");
                Console.WriteLine(" 2. triangle");
                Console.WriteLine(" 3. circle\n");

                choice = (Console.ReadLine());

                //rectangle

                if (choice == "1" || choice == "rectangle")
                {

                    Console.Write("enter width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("enter length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Area = {width * length}");
                    Console.ReadKey();
                }

                //triangle

                else if (choice == "2" || choice == "triangle")
                {
                    Console.Write("enter Base : ");
                    float Base = float.Parse(Console.ReadLine());
                    Console.Write("enter Height : ");
                    float Height = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Area = {0.5 * Base * Height}");
                    Console.ReadKey();
                }

                //circle

                else if (choice == "3" || choice == "triangle")
                {
                    Console.Write("enter Radius : ");
                    float Radius = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Area = {Math.PI * Radius}");
                    Console.ReadKey();
                }


                //wait at end


                Console.WriteLine("Would you like to choose another shape?");

                choice = (Console.ReadLine());
            }    
        }
    }
}
