using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_of_function
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteParabolaMinX(1, 2, 3);
            WriteParabolaMinX(0, 3, 2);
            WriteParabolaMinX(5, 2, 1);
            WriteParabolaMinX(4, 3, 2);
            WriteParabolaMinX(0, 4, 5);
        }

        private static void WriteParabolaMinX(int a, int b, int c)
        {
            if (a != 0)
            {
                double x = -b / (2.0 * a);
                double y = a * x * x + b * x + c;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}
