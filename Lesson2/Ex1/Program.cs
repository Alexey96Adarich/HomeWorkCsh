using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Min()
        {
            int a, b, c, min;
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            c = Convert.ToInt32(Console.ReadLine());
            min = a < b && a < c ? a : b > c ? b : c;
            Console.WriteLine("Минимальное число " + min);
            Console.ReadKey();
        }
       
        static void Main(string[] args)
        {
            //Написать метод, возвращающий минимальное из трёх чисел.

            Min();


        }
    }
}
