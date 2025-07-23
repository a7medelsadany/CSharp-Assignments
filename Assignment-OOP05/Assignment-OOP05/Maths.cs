using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP05
{
    internal  class Maths
    {
        
        public static void sum(int num1, int num2)
        {
            Console.WriteLine($"sum is {num1+num2}");
        }
        public static void sub(int num1, int num2)
        {
            Console.WriteLine($"sub is {num1 - num2}");
        }
        public static void multi(int num1, int num2)
        {
            Console.WriteLine($"multiple is {num1 * num2}"); 
        }
        public static void div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("cannot divide by zero");
                return;
            }
            Console.WriteLine($"divide is {num1 / num2}");
        }
        
    }
}
