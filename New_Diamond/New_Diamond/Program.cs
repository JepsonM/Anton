using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;
            int number_of_stars;
            Console.Write("Please type odd number(1 to 19): ");
            number_of_stars = Convert.ToInt32(Console.ReadLine());
            int space = 0;
            bool nogood = false;

            while (!nogood)
            {
                if ((number_of_stars >= 1) && (number_of_stars <= 19) && (number_of_stars % 2 != 0))
                {
                    nogood = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    number_of_stars = Convert.ToInt32(Console.ReadLine());
                }
            }

            while (row <= number_of_stars)
            {
                for (column = 0; column < number_of_stars / 2 - space; column++)
                {
                    Console.Write(" ");
                }
                for (column = 0; column <= row; column++)
                {
                    Console.Write("*");
                }
                row += 2;
                space++;
                Console.WriteLine();
            }
            row -= 2;
            space--;

            while (row >= 0)
            {
                for (column = 0; column < number_of_stars / 2 - space + 1; column++)
                {
                    Console.Write(" ");
                }
                for (column = 0; column < row -1; column++)
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
