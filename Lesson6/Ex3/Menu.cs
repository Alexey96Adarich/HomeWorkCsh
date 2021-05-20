using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public static void Start()
        {
            Function.GenerationCollection(30);

            int course5 = 0;
            int course6 = 0;
            List<Student> list = new List<Student>(); // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("list.csv");
            int[] count = new int[6]; // массив из количества студентов 18-20 лет, обучающихся на 1-6 курсах

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], int.Parse(s[2]), int.Parse(s[3])));

                    //  подсчитываем количество студентов 5 и 6 курсов
                    if (int.Parse(s[2]) == 5)
                    {
                        course5++;
                    }
                    else if (int.Parse(s[2]) == 6)
                    {
                        course6++;
                    }

                    // заполняем массив количества студентов 18, 19, 20 лет, обучающихся на 1-6 курсах
                    if (int.Parse(s[3]) >= 18 && int.Parse(s[3]) <= 20)
                    {
                        count[int.Parse(s[2]) - 1]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            list.Sort(new Comparison<Student>(Function.MyDelegat1)); // сортируем по возрасту          

            Console.WriteLine("Студентов 5 курса: {0}", course5);
            Console.WriteLine("Студентов 6 курса: {0}", course6);
            Console.WriteLine();

            Console.WriteLine("Список студентов, отсортированных по возрасту:");
            foreach (var v in list)
            {
                Console.WriteLine("Возраст {0}: {1} {2}", v.age, v.surname, v.name);
            }
            Console.WriteLine();

            Console.WriteLine("Количество студентов 18-20 лет, обучающихся на 1-6 курсах:");
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine("Курс: {0} Кол-во: {1}", i + 1, count[i]);
            }
            Console.WriteLine();

            list.Sort(new Comparison<Student>(Function.MyDelegat2)); // сортируем по курсу и возрасту        
            Console.WriteLine("Список студентов, отсортированных по курсу и возрасту:");
            foreach (var v in list)
            {
                Console.WriteLine("Курс: {0} Возраст: {1}: {2} {3}", v.course, v.age, v.surname, v.name);
            }
            Console.WriteLine();

            Console.WriteLine("Время выполнения программы = " + (DateTime.Now - dt));
            Console.ReadKey();
        }
    }
}
