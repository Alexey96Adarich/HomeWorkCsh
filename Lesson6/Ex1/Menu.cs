using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lesson6
{
    class Menu
    {
        /// <summary>
        /// 1.Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
        ///   Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
        /// </summary>
        public static void NewMethod()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции x^3:");
            Ret.Table(Ret.MyFunc, -2, 2);
            Console.WriteLine("Таблица функции x^2:");
            Ret.Table(Ret.Pow, -2, 2);
            Console.WriteLine("Таблица функции a*x^2:");
            Ret.Tab(Ret.Fen, 5, 2, 10);
            Console.WriteLine("Таблица функции a*sin(x):");
            Ret.Tab(Ret.Sin, 5, -10, 10);
        }
    }
}