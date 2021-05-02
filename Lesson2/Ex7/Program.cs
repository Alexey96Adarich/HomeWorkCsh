using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Numbers(int a, int b)
        {
            int sum = 0;
            Console.Write("{0,3} ", a);
            Console.WriteLine("Сумма чисел равна: " + sum);
            if (a < b)
            {
                sum = sum + a;

                Numbers(a + 1, b);
            }
        }


        static void Main(string[] args)
        {
           //Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
           //*Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine("Введите диапазон чисел от");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("до");
            int b = Convert.ToInt32(Console.ReadLine());
            Numbers(a, b);

       }
      
    }
}
