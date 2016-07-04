using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Equivalent_of_a_Binary_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int dec = 0; // the decimal we want to get from conversion
            int binary = 0; // *2
            int index = 0;
            int multiplier = 1;

            Console.WriteLine("Binary integer ");
            number = Console.ReadLine(); // Arbitrary binary number as a string from user

            index = number.Length; // Return length of the string which is binary number

            while (index > 0)
            {
                binary = Convert.ToInt32(number.Substring(index - 1, 1)); // length exceeds the total index by 1
                dec += (binary * multiplier);
                index--;
                multiplier *= 2;
            }

            Console.WriteLine("Converted number is {0} from {1:N}", number, dec); // :N is for 0s after .
            Console.ReadLine(); // Unnecessary.
        }
    }
}
