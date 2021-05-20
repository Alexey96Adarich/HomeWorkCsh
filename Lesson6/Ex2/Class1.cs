using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ex2;

namespace ex2
{
    delegate double Function(double a, double x);
    class Class1 : Class1Base
    {

        private static double F1(double a, double x)
        {
            return a * x * x;
        }
        private static double F2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        public static void NewMethod()
        {
            int[] variables = new int[3];
            Function[] F = { F1, F2 };

            Console.Write("Выберите функцию: нажмите 1 для - a*x^2; или 2 для - a*sin(x): ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("На каком отрезке функции находить минимум?\n" +
                "Введите начальное значение и конечное");
            variables[1] = Convert.ToInt32(Console.ReadLine());
            variables[2] = Convert.ToInt32(Console.ReadLine());
            SaveFunc("data.bin", variables[1], variables[2], 0.5, F[index - 1]);
            double min = double.MaxValue;
            Console.WriteLine(Load("data.bin", out min));
            PrintResults(variables[1], variables[2], 0.5, Load("data.bin", out min));
            Console.ReadKey();
        }
    }
}
