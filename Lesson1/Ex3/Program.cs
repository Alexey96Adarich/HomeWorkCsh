using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        private static void NewMethod()
        {
            Console.WriteLine(" ВВедите коордитнаты  первой точки x1 и y1, через Enter");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ВВедите коордитнаты  второй точки x2 и y2, через Enter");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    //Math.Sqrt  квадратный корень из числа
            Console.WriteLine(("Расстояние между 2 точками ") + Convert.ToDouble($"{r:F2}"));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
            //r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            NewMethod();

        }

       
    }
}
