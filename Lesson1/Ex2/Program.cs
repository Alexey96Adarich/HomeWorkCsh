using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ввести вес и рост человека.
            //  Рассчитать и вывести индекс массы тела(ИМТ) по формуле:
            //  I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.


            Console.WriteLine("Введите ваш вес, в кг");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост, в метрах");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = (double)a / (b * b);
            Console.WriteLine(("Ваш индекс массы тела равен ") + Convert.ToDouble($"{c:F2}"));

            Console.ReadLine();
        }
    }
}
