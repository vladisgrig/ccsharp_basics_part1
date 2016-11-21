using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expr1.Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной.Стоит ли так делать?
            int a = 2;
            int b = 4;
            SwapVariables(a, b);

            //Expr2.Задается натуральное трехзначное число (гарантируется, что трехзначное).Развернуть его, т.е.получить трехзначное число, записанное теми же цифрами в обратном порядке.
            int c = 456;
            ExpandNumber(c);

            //Expr3.Задано время Н часов(ровно).Вычислить угол в градусах между часовой и минутной стрелками.Например, 5 часов-> 150 градусов, 20 часов-> 120 градусов.Не использовать циклы.
            Console.WriteLine("Введите число от 0 до 24");
            CalculateAngle(Console.ReadLine());


            //Expr4.Найти количество чисел меньших N, которые имеют простые делители X или Y.
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите простой делитель X:");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите простой делитель Y:");
            int Y = int.Parse(Console.ReadLine());
            FindNumberOfIntegersByDivider(N, X, Y);


            //Expr5.Найти количество високосных лет на отрезке[a, b] не используя циклы.

            //Expr6.Посчитать расстояние от точки до прямой, заданной двумя разными точками.

            //Expr7.Найти вектор, параллельный прямой.Перпендикулярный прямой.

            //Expr8.Дана прямая L и точка A.Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A.

        }

        private static void FindNumberOfIntegersByDivider(int n, int x, int y)
        {
            int count = 0;
            while (n > 1)
            {
                n--;
                if ((n % x == 0) && (n % y == 0))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void CalculateAngle(string str_hour)
        {
            int hour = int.Parse(str_hour);
            if (hour > 6)
            {
                int angle = (12 - (hour % 12)) * 30;
                Console.WriteLine("Угол равен: {0}", angle);
            }
            else
            {
                int angle = (hour % 12) * 30;
                Console.WriteLine("Угол равен: {0}", angle);
            }

            
        }

        static void ExpandNumber(int c)
        {
            char[] charArray = c.ToString().ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("{0} after expand is {1}", c, new string(charArray));
            Console.WriteLine();
        }

        static void SwapVariables(int a, int b)
        {
            Console.WriteLine("a is {0}, b is {1}", a, b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine();
        }
    }
}
