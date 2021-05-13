using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lessons4
{
    class MyArray
    {
        public static void Array()
        {
            //Дан целочисленный  массив из 20 элементов.
            //Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.
            //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива.
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            int[] array = new int[20];
            Console.WriteLine("Массив элементов из случайных чисел:");
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10000, 10000);    
                Console.Write("{0} ", array[i]);
            }
            
            //Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            Class1.Static(array);

            //б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            Console.WriteLine("\n" + "Пункт Б. Статический метод считывания массива из текстового файла.");
            LoadFile.LoadArrayFromFile(@"data.txt");

            //в)**Добавьте обработку ситуации отсутствия файла на диске.
            Console.WriteLine("Пункт В. Обработка ситуации отсутствия файла на диске.");
            NoLoadFile.Test("Начинаю считывать данные из файла 'не существует.txt'. Нажмите любую кнопку...");
            string[] arrNoLoaded = default;
            try
            {
                arrNoLoaded = LoadFile.LoadArrayFromFile(@"..\..\не существует.txt");
            }
            catch (Exception e)
            {
                NoLoadFile.Test(e.Message + "\nДальнейшая работа программы невозможна. Нажмите любую кнопку ...");
                return;
            }
        }
    }
}