using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void SumGood(int x, int y)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = x; i <= y; i++)
            {
                int sum = 0;
                int good = i;
                while (good != 0)
                {
                    sum += good % 10;
                    good /= 10;
                }

                if (i % sum == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество хороших чисел: {0}", count);
            Console.WriteLine("Время выполнения программы: {0}", DateTime.Now - start);
        }

        static void Main(string[] args)
        {
            //Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //«Хорошим» называется число, которое делится на сумму своих цифр.
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            SumGood(a,b);


        }
    }
}
