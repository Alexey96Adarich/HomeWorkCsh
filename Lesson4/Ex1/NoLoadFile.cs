using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons4
{
    class NoLoadFile
    {
        internal static void Test(string text = "Для продолжения нажмите любую кнопку ...")
        {
            Console.WriteLine(text + "\n");
            Console.ReadKey();
        }
    }
}
