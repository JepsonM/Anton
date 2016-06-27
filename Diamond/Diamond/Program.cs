using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;
            const int number_of_stars = 9;
            int space = 0;

            // First loop: From the beginning to the middle
            for (row = 0; row <= number_of_stars; row += 2, space++)
            {
                for (column = 0; column < number_of_stars / 2 - space; column++)
                {
                    Console.Write(" ");
                }
                for (column = 0; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            row -= 2;
            space--;

            // Second loop: 4 rows after the middle
            while (row >= 0)
            {
                for (column = 0; column < number_of_stars / 2 - space + 1; column++)
                {
                    Console.Write(" ");
                }
                for (column = 0; column < row - 1; column++)
                {
                    Console.Write("*");
                }
                row -= 2;
                space--;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
