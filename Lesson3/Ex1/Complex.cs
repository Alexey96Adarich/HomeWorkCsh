using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    struct Complex
    {
        public double re;
        public double im;


        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public static Complex Sum(Complex q, Complex w)
        {
            Complex result = new Complex();
            result.re = q.re + w.re;
            result.im = q.im + w.im;
            return result;
        }
        public static Complex Raz(Complex q, Complex w)
        {
            Complex result = new Complex();
            result.re = q.re - w.re;
            result.im = q.im - w.im;
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"{re} + {im}i");

        }
    }
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 


    class SComplex
    {
        double im;
        double re;

        public SComplex()
        {
            im = 0;
            re = 0;
        }
        // Конструктор, в котором задаем поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public SComplex(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            this.re = re;
        }

        public SComplex Plus(SComplex x2)
        {
            SComplex x3 = new SComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public SComplex Minus(SComplex x2)
        {
            SComplex x4 = new SComplex();
            x4.im = x2.im - im;
            x4.re = x2.re - re;
            return x4;
        }

        public SComplex Multi(SComplex x2)
        {
            SComplex x5 = new SComplex();
            x5.im = im * x2.re + re * x2.im;
            x5.re = re * x2.re - im * x2.im;
            return x5;

        }
        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; } // вызываем переменную im
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value; // при определенном условии меняем значение im
            }
        }
        // Специальный метод, который возвращает строковое представление данных.

        public string ToString()
        {
            return re + "+" + im + "i";
        }
        public void Print()
        {
            Console.WriteLine($"{re} + {im}i");

        }
    }
}
