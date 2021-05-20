using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Function : MyDelegat
{
    /// <summary>
    /// Генератор списка фамилий, имен, курсов, возрастов
    /// </summary>
    /// <param name="n">Количество студентов</param>
    public static void GenerationCollection(int n)
    {
        StreamWriter generList = new StreamWriter(new FileStream("list.csv", FileMode.Create, FileAccess.Write));
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            // генерируем случайные фамилии
            int z = rand.Next(2, 10);
            char[] surname = new char[z];
            for (int j = 0; j < z; j++)
            {
                if (j == 0)
                {
                    surname[j] = (char)rand.Next(0x0041, 0x005A);
                }
                else
                {
                    surname[j] = (char)rand.Next(0x0061, 0x007A);
                }
            }

            // генерируем случайные имена
            int y = rand.Next(2, 10);
            char[] name = new char[y];
            for (int j = 0; j < y; j++)
            {
                if (j == 0)
                {
                    name[j] = (char)rand.Next(0x0041, 0x005A); //A-Z
                }
                else
                {
                    name[j] = (char)rand.Next(0x0061, 0x007A); //a-z
                }
            }

            // генерируем курс
            int cource = rand.Next(1, 6);

            // генерируем возраст
            int age = rand.Next(17, 25);

            // записываем строку в csv файл
            generList.WriteLine(new string(surname) + ";" + new string(name) + ";" + cource + ";" + age);
        }
        generList.Close();
    }
}