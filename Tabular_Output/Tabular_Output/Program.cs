using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabular_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine("N  10*N  100*N   1000*N");

            for (n = 1; n < 6; n++)
            {
                int n10 = 10 * n;
                int n100 = 100 * n;
                int n1000 = 1000 * n;
                Console.WriteLine("{0}  {1}     {2}     {3}", n, n10, n100, n1000);
            }
        }
    }
}
