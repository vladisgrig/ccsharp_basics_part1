using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percents
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine(Calculate(inputString));


        }

        private static double Calculate(string userInput)
        {
            string[] splitedInputString = userInput.Split(' ');
            double summ = double.Parse(splitedInputString[0], System.Globalization.CultureInfo.InvariantCulture);
            double perc = double.Parse(splitedInputString[1], System.Globalization.CultureInfo.InvariantCulture);
            double period = double.Parse(splitedInputString[2], System.Globalization.CultureInfo.InvariantCulture);

            double result = summ * System.Math.Pow((perc / 100) / 12 + 1, period);
            return result;
        }
    }
}
