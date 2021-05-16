using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Class1
    {
        public static void NewMethod()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            /// а) без использования регулярных выражений;           
            Console.WriteLine("Результат проверки на корректность без регулярных выражений: {0}", Bool.LogInNoReg(login));
            /// б) **с использованием регулярных выражений.
            Console.WriteLine("Результат проверки на корректность без регулярных выражений: {0}", Bool.LogInReg(login));
        }

    }
}