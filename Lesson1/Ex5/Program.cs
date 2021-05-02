using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).


            Console.WriteLine("имя");
            string a = Console.ReadLine();
            Console.WriteLine("фамилия");
            string b = Console.ReadLine();
            Console.WriteLine("город");
            string c = Console.ReadLine();

            Console.SetCursorPosition(50, 14);   // как найти центр? 
            Console.WriteLine(a.ToString() + " " + b.ToString() + ", город " + c.ToString());
            Console.ReadKey();


        }
    }
}
