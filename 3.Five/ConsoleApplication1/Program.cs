using System;


namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Write the digits ");
            number = Convert.ToInt32(Console.ReadLine());
            int first = number / 10000;
            int second = number % 10000 / 1000;
            int third = number % 1000 / 100;
            int fourth = number % 100 / 10;
            int fifth = number % 10;

            Console.WriteLine("{0}   {1}   {2}   {3}   {4}", first, second, third, fourth, fifth);


            


           
            
        }
    }
}
