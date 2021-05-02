using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу «Анкета».
            //Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            Console.WriteLine("Анкета");
            Console.WriteLine("Введите свое имя");
            string a = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string b = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой рост");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            double f = Convert.ToDouble(Console.ReadLine());
            // a
            Console.WriteLine(Convert.ToString(a) + " " + Convert.ToString(b) + ", " + Convert.ToDouble(c) + " лет, " + "рост " + Convert.ToInt32(d) + ", вес " + Convert.ToDouble(f));
            //  b
            Console.WriteLine(String.Format("{0} {1}, {2} лет, рост {3}, вес {4}", a, b, c, d, f));
            //  c
            Console.WriteLine($"{a} {b}, {c} лет, рост {d}, вес {f}");
            Console.ReadLine();
        }
    }
}
