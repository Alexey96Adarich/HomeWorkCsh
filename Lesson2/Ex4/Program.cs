using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
       static void Data()
        {
            Console.WriteLine("Введите Логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите Пароль");
            string password = Console.ReadLine();            
            NewMethod(login, password);
        }

       static void NewMethod(string a, string b)
       {
                //Wert();
                if (a == "root" && b == "GeekBrains")
                {
                    Console.WriteLine("Верно");
                return;
                }
                else
                {
                int count = 1;
                do
                {
                    Console.WriteLine("Данные введены не верно, попробуй еще раз");
                    Console.WriteLine("Введите логин");
                    string s = Console.ReadLine();
                    Console.WriteLine("Введите Пароль");
                    string d = Console.ReadLine();
                    if (s == "root" && d == "GeekBrains")
                    {
                        Console.WriteLine("Верно");
                    }
                }
                while (count-- > 0);
                }   
       }

        static void Mein(string[] args)
        {
            // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //  На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //  С помощью цикла do while ограничить ввод пароля тремя попытками.
          Data();

        }
    }
}
