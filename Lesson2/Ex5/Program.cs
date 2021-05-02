using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Data()
        {
            Console.WriteLine("Введите ваш вес, в кг");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост, в метрах");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = (double)a / (b * b);
            if (c < 18.5)
            {
                Console.WriteLine(("Ваш индекс массы тела равен ") + Convert.ToDouble($"{c:F2}")+ " Вам нужно набрать: {0:F2} кг", (18.5 - c) * (b * b));               
            }
            else if( c >= 18.5 & c <= 25)
            {
                Console.WriteLine(("Ваш индекс массы тела равен ") + Convert.ToDouble($"{c:F2}") + " Ваш вес соответсвует нормам");
            }
            else if (c > 25)
            {
                Console.WriteLine(("Ваш индекс массы тела равен ") + Convert.ToDouble($"{c:F2}") + " Вам нужно похудеть: {0:F2} кг", (c - 25) * (b * b));
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Написать программу, которая запрашивает массу и рост человека, 
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            Data();

        }
    }
}
