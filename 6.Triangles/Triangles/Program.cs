﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // For empty space

            for (int i = 0; i < 10; i++)
            {
                for (int j = 11; j > i + 1; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // For empty space

            for (int i = 0; i < 10; i++) // for lines
            {                
                for (int j = 0; j < i; j++) // for spaces
                {                    
                    Console.Write(' ');                    
                }
                for (int j = 10; j > i; j--) // for stars
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++) // for lines
            {
                for (int j = 10; j > i + 1; j--) // for spaces
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i + 1; j++) // for spaces
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
