using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3
{
    class Menu
    {
        public static void Compare()
        {
            Console.WriteLine("Сравним 2 строки 'badc' и 'abcd', является ли одна перестановкой другой");
            Console.WriteLine(Class1.Compare_2_words("badc", "abcd"));

            Console.WriteLine("Сравним 2 строки 'badc' и 'abcde', является ли одна перестановкой другой");
            Console.WriteLine(Class1.Compare_2_words("badc", "abcde"));

            Console.WriteLine("Сравним 2 строки 'badc' и 'asds', является ли одна перестановкой другой");
            Console.WriteLine(Class1.Compare_2_words("badc", "asds"));
            Console.ReadKey();
        }

    }
}
