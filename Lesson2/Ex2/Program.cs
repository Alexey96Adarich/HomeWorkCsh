using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static int count(string s)
        {
            return s.Length;
        }
        static void Main(string[] args)
        {
            //Написать метод подсчета количества цифр числа

            Console.Write("Число: ");
            Console.WriteLine("Количество знаков: " + count(Console.ReadLine()));
            Console.ReadKey();
            
        }
    }
}
