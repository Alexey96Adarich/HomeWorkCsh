using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class View
    {
        public static void NewMethod()
        {

            Console.WriteLine("Пункт задания А. Дописать структуру Complex, добавив метод вычитания комплексных чисел.");
            Complex z1 = new Complex(re: 123, im: 23);
            Complex z2 = new Complex(re: 133, im: 43);
            Complex z3 = Complex.Sum(z1, z2);
            Complex z4 = Complex.Raz(z1, z2);

            z1.Print();
            z2.Print();
            Console.WriteLine("сумма");
            z3.Print();
            Console.WriteLine("разность");
            z4.Print();
            Console.WriteLine();
        }
        /// 
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// 
        public static void NewMethodTwo()
        {
            Console.WriteLine("Пункт задания Б. Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.");

            SComplex Scomplex1 = new SComplex(8, 9);
            SComplex Scomplex2 = new SComplex(20, 4);  // im  re

            Scomplex2.Im = 20;
            Scomplex1.Print();
            Scomplex2.Print();
            SComplex result = Scomplex1.Plus(Scomplex2);
            Console.WriteLine("сумма: " + result.ToString());

            SComplex resul = Scomplex1.Minus(Scomplex2);
            Console.WriteLine("разность: " + resul.ToString());

            SComplex resut = Scomplex1.Multi(Scomplex2);
            Console.WriteLine("Произведение: " + resut.ToString());
        }
    }
}
