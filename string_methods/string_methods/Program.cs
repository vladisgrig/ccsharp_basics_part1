using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }

        static string GetLastHalf(string text)
        {
            int length = text.Length;
            string right_half = text.Substring(length / 2);
            return right_half.Replace(" ", "");
        }
    }
}
