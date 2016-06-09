using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Program
    {
        public static void Main(string[] args)
        {
        int number1;
        Console.Write("First number ");
        number1 = Convert.ToInt32(Console.ReadLine());
        int number2;
        Console.Write("Second number ");
        number2 = Convert.ToInt32(Console.ReadLine());
        int number3;
        Console.Write("Thired number ");
        number3 = Convert.ToInt32(Console.ReadLine());
        int number4;
        Console.Write("Fourth number ");
        number4 = Convert.ToInt32(Console.ReadLine());
        int number5;
        Console.Write("Fifth number ");
        number5 = Convert.ToInt32(Console.ReadLine());

        int negative = 0;
        int zero = 0;
        int positive = 0;

        if (number1 < 0) 
        negative = negative + 1;
        else
        if (number1 == 0)
            zero = zero + 1;
        else
            if (number1 > 0)
            positive = positive + 1;

        if (number2 < 0) 
        negative = negative + 1;
        else
        if (number2 == 0)
            zero = zero + 1;
        else
            if (number2 > 0)
            positive = positive + 1;

        if (number3 < 0)
            negative = negative + 1;
        else
        if (number3 == 0)
            zero = zero + 1;
        else
            if (number3 > 0)
            positive = positive + 1;

        if (number4 < 0)
            negative = negative + 1;
        else
        if (number4 == 0)
            zero = zero + 1;
        else
            if (number4 > 0)
            positive = positive + 1;

        if (number5 < 0)
            negative = negative + 1;
        else
        if (number5 == 0)
            zero = zero + 1;
        else
            if (number5 > 0)
            positive = positive + 1;

        Console.WriteLine("The number of negatives are {0}", negative);
        Console.WriteLine("The number of positives are {0}", positive);
        Console.WriteLine("The number of zeros are {0}", zero);
    }
    }

