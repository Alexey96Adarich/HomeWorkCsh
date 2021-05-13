using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons4
{
    class LoadFile
    {
        string[] lines = new string[0];
        static string IntToString(int a)
        {
            return a.ToString();
        }
        public static string[] LoadArrayFromFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string[] lines = new string[0];
            ///считаем данный файла в массив
            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Массив загруженных элементов из файла: " + lines[i] + "\n");
                }
            }
            reader.Close();
            return lines;
            //запись в массив
            int[] nums = Array.ConvertAll(lines, int.Parse);
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= 1;
            }
            string[] newLine = Array.ConvertAll(nums, IntToString);
            File.WriteAllLines("newfile.txt", newLine);
            Console.Write(newLine);

        }
    }
}