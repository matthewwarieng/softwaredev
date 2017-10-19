using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //input


            Console.WriteLine("Enter in your birthdate:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            //calculation

            int age = DateTime.Today.Year - birthday.Year;



            //output

            if (age < 0)

            {
                Console.WriteLine("you aint even a fetus yet bruz");
            }

            else if (age < 12)
            {
                Console.WriteLine("you are a child, young one");
            }

            else if (age == 12)
            {
                Console.WriteLine("damn twelvie you are");
            }

            else if (age < 20)
            {
                Console.WriteLine("you a tween bro");
            }

            else if (age < 75)
            {
                Console.WriteLine("your an adult, have fun");
            }

            else if (age <= 95)
            {
                Console.WriteLine("you are an elderly");
            }

            else if (age > 95)
            {
                Console.WriteLine("you old, goooona die");
            }

            //wait at end

            Console.ReadKey();
            
        }
    }
}
