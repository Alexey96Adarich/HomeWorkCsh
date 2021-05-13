using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons4_3
{
    class Menu
    {
        public static void NewMethod()
        {
            MyArrBase1 massiv = new(10, 1, 3);
            Console.WriteLine("Массив:");
            massiv.Print();

            Console.WriteLine("Сумма элементов массива: " + "\n" + massiv.Sum);          // свойство

            massiv.Inverse();
            Console.Write("Инверсия: ");                     //метод
            massiv.Print();

            massiv.Multi(5);
            Console.Write("Умножаем на 5: ");                 //метод
            massiv.Print();

            Console.WriteLine("Количество максимальных элементов в массиве MainArray: " + massiv.MaxCount);        //свойство
        }
    }
}