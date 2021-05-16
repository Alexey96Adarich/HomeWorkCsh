using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3
{
    class Class1
    {
        /// <summary>
        /// сравним две строки: занеся их в массив и отсортировав
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static bool Compare_2_words(string word1, string word2)
        {
            if (word1.Length == word2.Length)
            {
                char[] array1 = word1.ToCharArray();
                char[] array2 = word2.ToCharArray();
                Array.Sort(array1);
                Array.Sort(array2);
                //Определим, совпадают ли две последовательности, используя Enumerable.SequenceEqual
                return Enumerable.SequenceEqual(array1, array2);
            }
            return false;
        }
    }
}
