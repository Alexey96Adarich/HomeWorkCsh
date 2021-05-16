using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lesson5._2
{
    public class MyString
    {
        string msg;

        public string Msg { get => msg; set => msg = value; }

        /// Объект класса для обработки текста      
        public MyString(string message)
        {
            msg = message;
        }

        public void Print()
        {
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("{0}", msg[i]);
            }
            Console.WriteLine();
        }
        /// Выводим слова длиной не больше n букв
        public void SearchWords(int n)
        {
            string onlyLetters = Clear(); // чистим текст
            string[] words = onlyLetters.Split(' '); // разбиваем на массив из слов

            Console.WriteLine("\n" + "Список слов длиной не больше {0} симв.:", n);
            foreach (string item in words)
            {
                if (item.Length <= n)     //////поменять на <=  
                {
                    Console.Write(item + ", ");
                }
            }
            Console.WriteLine();
        }
        // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
        public void ClearLastSymbol(char s)
        {
            string onlyLetters = Clear();
            string[] words = onlyLetters.Split(' '); // разбиваем на массив из слов
            List<string> words_list = new List<string>(words);

            foreach (string item in words)
            {
                if (item.Length > 0 && item[item.Length - 1] == s)
                {
                    words_list.Remove(item);
                }
            }

            Console.WriteLine("\n" + "Сообщение без слов с символом \"{0}\" на конце:\n{1}", s, String.Join(" ", words_list));
        }

        //в) Найти самое длинное слово сообщения
        ///Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.  
        public void SearchLongestWords()
        {
            string onlyLetters = Clear();
            // разбиваем на массив из слов
            string[] words = onlyLetters.Split(' ');
            int maxLetters = 0;
            foreach (string item in words)
            {
                if (item.Length > maxLetters)
                {
                    maxLetters = item.Length;
                }
            }

            int max = maxLetters;
            Regex regex = new Regex(@"\w{" + max + @"}\b");
            StringBuilder returnMe = new StringBuilder();
            MatchCollection collection = regex.Matches(onlyLetters);
            foreach (var elem in collection)
            {
                returnMe.Append($"{elem} ");
            }
            Console.WriteLine("\n" + "Самое длинное слово в тексе состоит из - " + maxLetters + " букв и это слово: " + returnMe.ToString());
        }

        /// Удаляем из текста лишние символы: пунктуация, цифры и пр.
        public string Clear()
        {
            string msg2 = msg;
            string pattern = @"[^a-zA-Zа-яА-я\s]"; // любой символ за исключением a-z, A-Z, а-я, А-Я и пробела
            string target = ""; // менять будем на пустоту
            Regex regex = new Regex(pattern);
            string onlyLetters = regex.Replace(msg2, target); // остаются только буквы и пробелы

            // убираем двойные пробелы
            string pattern2 = @"[\s+]"; // любой ряд пробелов
            string target2 = " "; // менять на пробел
            Regex regex2 = new Regex(pattern2);
            onlyLetters = regex2.Replace(onlyLetters, target2); // остаются только буквы и одинарные пробелы

            // Console.WriteLine("Текст после чистки:{0}", onlyLetters);
            return msg;
        }
    }
}
