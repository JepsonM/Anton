using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkerboard_Pattern_of_Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter1 = 1; //Big loop counter
            int counter2 = 1; //Small loop counter

            while (counter1 <= 8) //Loop for \n
            {
                if (counter1 % 2 != 0) //For odd number rows
                {
                    while (counter2 <= 8) 
                    {
                        Console.Write("* ");
                        counter2++;
                    }
                }
                else //For even number rows, insert a space
                {
                    Console.Write(" "); //Single space insert
                    while (counter2 <= 8)
                    {
                        Console.Write("* ");
                        counter2++;
                    }
                }
                counter2 = 1;
                counter1++;
                Console.WriteLine();
            }
        }
    }
}
