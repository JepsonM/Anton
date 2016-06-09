using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Chapter5_18 //Credit Limit Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountnumber;
            Console.Write("Account number ");
            accountnumber = Convert.ToInt32(Console.ReadLine());
            int balance_begin;
            Console.Write("Beginning balance ");
            balance_begin = Convert.ToInt32(Console.ReadLine());
            int total_item_charged;
            Console.Write("Total of all times charged ");
            total_item_charged = Convert.ToInt32(Console.ReadLine());
            int total_credit_applied;
            Console.Write("Total of all credits applied ");
            total_credit_applied = Convert.ToInt32(Console.ReadLine());
            int allowed_credit;
            Console.Write("Allowed credits ");
            allowed_credit = Convert.ToInt32(Console.ReadLine());
            int balance_new = balance_begin + total_item_charged - total_credit_applied;

            if (balance_new > allowed_credit)
            {
                Console.WriteLine("Credit limit exceeded");
            }
            else
            {
                Console.WriteLine("You are good");
            }

        }
    }
}*/

/*namespace Chapter5_23 //Find the two largest numbers
{
    class program
    {
        public static void Main(string[] args)
        {
            int counter;
            int number;
            
            int largest = int.MinValue;
            int second_largest = int.MinValue;

            for (counter = 0; counter < 10; counter++)
            {
                Console.Write("Give me the number ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > largest)
                {
                    largest = number;
                }
                else if (number > second_largest && largest > second_largest)
                {
                    second_largest = number;
                }
            }
            Console.WriteLine("The largest number is {0}", largest);
            Console.WriteLine("The second largest number is {0}", second_largest);
        }
    }
}*/

/*namespace Chapter5_22 //Tabular Output
{
    class program
    {
        public static void Main(string[] args)
        {
            int n = 1;

            Console.WriteLine("N  10*N  100*N  1000*N");
            for (n = 1; n < 6; n++)
            {
                int n10 = 10 * n;
                int n100 = 100 * n;
                int n1000 = 1000 * n;
                Console.WriteLine("{0}  {1}     {2}    {3}", n, n10, n100, n1000);
            }
        }
    }
}*/

