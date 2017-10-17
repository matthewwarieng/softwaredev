using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

                Console.WriteLine("enter number X") ;
                float X = float.Parse( Console.ReadLine());
                Console.WriteLine("enter number Y") ;
                float Y = float.Parse(Console.ReadLine()) ;


            //output

                Console.WriteLine($"{X} plus {Y} = {(X + Y)}")  ;
                Console.WriteLine($"{X} times {Y} =  {(X * Y)}") ;
                Console.WriteLine($"{X} minus {Y} =  {(X - Y)} ") ;
                Console.WriteLine($"{X} divided by {Y} =  {(X / Y)}") ;

            //Wait at end
            Console.ReadLine();
        }
    }
}
