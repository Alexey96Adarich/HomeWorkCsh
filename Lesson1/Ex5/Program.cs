using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Print(string a, string b, string c)

        {
            Console.SetCursorPosition(50, 14);   // как найти центр? 
            Console.WriteLine(a.ToString() + " " + b.ToString() + ", город " + c.ToString());
            Console.ReadKey();
        }
        private static void NewMethod(out string a, out string b, out string c)
        {
            Console.WriteLine("имя");
            a = Console.ReadLine();
            Console.WriteLine("фамилия");
            b = Console.ReadLine();
            Console.WriteLine("город");
            c = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            string a, b, c;
            NewMethod(out a, out b, out c);

            Print(a, b, c);
        }

        





    }
}
