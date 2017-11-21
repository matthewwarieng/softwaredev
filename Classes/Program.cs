using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Dan", "Phal", 49);

            p.Sit();
            p.Walk(100);
            p.Stand();
            p.Birthday();
            p.Walk(100);
            p.printInfo();
        }
    }

    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private bool sitting;
        private int steps;

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            sitting = true;
            steps = 0;
        }
        public void Walk(int steps)
        {
            if (sitting)
            {
                Console.WriteLine("You cant walk you are sitting");
            }

            else
            {
                Console.WriteLine($"{firstname} {lastname} just walked {steps} steps");
                this.steps += steps;
            }
        }

        public void Birthday()
        {
            age ++;
        }

        public void printInfo()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstname} {lastname} is {age} years old, is currently sitting" +
                    $"and has taken {steps} steps.");
            }

            else
            {
                Console.WriteLine($"{firstname} {lastname} is {age} years old, is currently standing" +
                    $"and has taken {steps} steps.");
            }

            Console.WriteLine("Press any Key to contiue");
            Console.ReadLine();
        }

        public void Sit()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstname} {lastname} is already sitting");
            }

            else
            {
                sitting = true;
            }

        }

        public void Stand()
        {
            if (sitting)
            {
                sitting = false;
            }

            else
            {
                Console.WriteLine($"{firstname} {lastname} is already standing.");
            }
        }

    }

}
