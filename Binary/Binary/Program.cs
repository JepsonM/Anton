using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int conversion = 0;
            int binary = 0;
            int index = 0;
            int multiplier = 1;

            Console.WriteLine("Enter a binary number: ");
            number = Console.ReadLine();

            index = number.Length; // Some kind of conversion by counting the length of string in number

            while (index > 0) //Iteration for multiplication of each number on the string
            {
                binary = Convert.ToInt32(number.Substring(index-1, 1)); 
                conversion += binary * multiplier;
                index--; 
                multiplier *= 2;
            }

            Console.WriteLine("Converted number from {0} is {1:N0}", number, conversion); // N0 stands for removing dot.
            Console.ReadLine();
        }
    }
}
