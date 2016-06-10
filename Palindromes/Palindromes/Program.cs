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
            int number;
            Console.WriteLine("Give me the number ");
            number = Convert.ToInt32(Console.ReadLine());
            int first = number / 10000;
            int second = number / 1000 % 10;
            int third = number / 100 % 10;
            int fourth = number / 10 % 10;
            int fifth = number % 10;
            
            while (number < 10000)
            {
                Console.WriteLine("Error occurred. Please type the number again");
                number = Convert.ToInt32(Console.ReadLine());
                while (number > 9999 && number < 100000)
                {
                    if ((first == fifth) && (second == fourth))
                    {
                        Console.WriteLine("The number is parlindromes");
                        break;
                    }
                    if ((first != fifth) || (second != fourth))
                    {
                        Console.WriteLine("Nah");
                        break;
                    }
                }
            }
        }
    }
}
