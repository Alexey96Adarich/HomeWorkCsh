using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Class1
    {
        public static void NewMethod()
        {
            Console.WriteLine("Вводите числа через Enter");
            int sum = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int a)) ;
                {
                    if (a != 0 && a > 0 && a % 2 != 0)
                    {
                        sum = sum + a;
                        Console.WriteLine(" Сумма нечетных чисел: " + sum);
                    }

                    else if (a == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введен неверный формат целого числа!");
                        Console.Beep(500, 500);
                    }
                    continue;
                }


            }
        }
    }
}
