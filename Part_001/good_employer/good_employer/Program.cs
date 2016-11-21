using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace good_employer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintGreeting("Student", 10.01));
            Console.WriteLine(PrintGreeting("Bill Gates", 10000000.5));
            Console.WriteLine(PrintGreeting("Steve Jobs", 1));
        }

        private static string PrintGreeting(string name, double salary)
        {
            return String.Format("Hello, {0}, your salary is {1}", name, Math.Ceiling(salary));
        }
    }
}
