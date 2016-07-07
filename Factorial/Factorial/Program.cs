using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int Factorial(int num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }
            
            return num * Factorial(num - 1);
        }
        static void Main(string[] args)
        {             
            Console.Write("Enter a non-negative integer ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}! is {1}", number, Factorial(number));
        }
    }
}
