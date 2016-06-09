using System;




    public class Program
    {
        public static void Main(string[] args)
        {
        int number;
        Console.WriteLine("Give me the number ");
        number = Convert.ToInt32(Console.ReadLine());

            

            if (number % 2 == 0)
            Console.WriteLine("This number is even ");

            else
                
            Console.WriteLine("This number is odd ");
        }
    }

