using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_question_in_universe
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }

        static int GetSquare(int x)
        {
            return x * x;
        }

        static void Print(int num)
        {
            Console.WriteLine(num.ToString());
        }
    }
}
