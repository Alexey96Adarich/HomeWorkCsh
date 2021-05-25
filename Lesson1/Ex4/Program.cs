using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        private static void NewMethod()
        {
            //a
            Console.Write("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}, b = {b}");

            //b

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b}");    // Вернули значения a и b в первоначальное значение, но без 3 переменной
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            
            NewMethod();
        }

        
    }
}
