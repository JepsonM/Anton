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
            int dec = 0;
            int binary = 0;
            int index = 0;
            int multiplier = 1;

            Console.WriteLine("Binary integer ");
            number = Console.ReadLine();

            index = number.Length;

            while (index > 0)
            {
                binary = Convert.ToInt32(number.Substring(index - 1, 1));
                dec += (binary * multiplier);
                index--;
                binary *= 2;
            }

            Console.WriteLine("Converted number is {0} from {1:N}", number, dec);
            Console.ReadLine();
        }
    }
}
