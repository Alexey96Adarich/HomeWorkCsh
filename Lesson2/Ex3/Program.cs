using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {


            //С клавиатуры вводятся числа, пока не будет введен 0.
            //Подсчитать сумму всех нечетных положительных чисел.

            int sum = 0;
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    if (a % 2 != 0)
                    { 
                        sum += a;
                    }           
                    Console.WriteLine(" Сумма нечетных чисел: " + sum);
                }
                else
                {
                    break;
                }
            }


        }

    }
}
