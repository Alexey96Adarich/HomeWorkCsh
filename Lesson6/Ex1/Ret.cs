using System;


namespace Lesson6
{
    class Ret
    {
        /// <summary>
        /// вывод значения
        /// </summary>
        /// <param name="F">функция</param>
        /// <param name="a">аргумент начальный</param>
        /// <param name="end">предел</param>
        public static void Table(Fun F, double a, double end)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (a <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", a, F(a));
                a += 1;
            }
            Console.WriteLine("---------------------");
        }
        /// <summary>
        /// Вывод значения
        /// </summary>
        /// <param name="S">функция</param>
        /// <param name="x">до умножение</param>
        /// <param name="a">аргумент начальный</param>
        /// <param name="end">предел</param>
        public static void Tab(Fut S, double x, double a, double end)
        {
            Console.WriteLine("-----A------ X ----- Y -----");
            while (a <= end)
            {
                Console.WriteLine($"| {a,8:F3} | {x,8:F3} | {S(x, a),8:F3} |");
                a++;
            }
            Console.WriteLine("---------------------");
        }
        /// <summary>
        /// куб
        /// </summary>
        /// <param name="x">аргумент</param>
        /// <returns></returns>
        public static double MyFunc(double x) => x * x * x;
        /// <summary>
        /// квадрат
        /// </summary>
        /// <param name="x">аргумент</param>
        /// <returns></returns>
        public static double Pow(double x) => x * x;
        /// <summary>
        /// a*x^2
        /// </summary>
        /// <param name="a">до умножение</param>
        /// <param name="x">аргумент</param></param>
        /// <returns></returns>
        public static double Fen(double a, double x) => a * x * x;
        /// <summary>
        /// a*sin(x)
        /// </summary>
        /// <param name="a">аргумент начальный</param>
        /// <param name="x">до умножение </param>
        /// <returns></returns>
        public static double Sin(double a, double x) => a * Math.Sin(x);
    }
}