using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            string backnumber = "";
            int count = 0;

            Console.WriteLine("Please type the number: ");
            number = Console.ReadLine();

            while (number.Length != 5)
            {
                Console.WriteLine("Invalid Input. Please type the number again: ");
                number = Console.ReadLine();
            }

            count = number.Length - 1;

            while (count >= 0)
            {
                backnumber += number.Substring(count, 1);
                count--;
            }

            if (number == backnumber)
            {
                Console.WriteLine("{0} is a palindrome.", number);
            }

            else
            {
                Console.WriteLine("{0} is not a palindrome", number);
            }
        }
    }
}
