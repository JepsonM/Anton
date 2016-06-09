using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_largest_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; 
            Console.Write("Enter the integer ");
            number = Convert.ToInt32(Console.ReadLine()); // integers as an input
            int largest = int.MinValue; //refreshing the largest value
            int second_largest = int.MinValue; //refreshing the second largest value

            for (int i = 0; i < 10; i++) // 10 times loop
            {
                if (number > largest) //for the largest integer
                {
                    largest = number;
                }
                else if (number > second_largest && largest > second_largest) //two conditions for second largest
                {
                    second_largest = number;
                }
            }
            Console.WriteLine("The largest integer is {0}", largest);
            Console.WriteLine("The second largest integer is {0}", second_largest);
        }
    }
}
