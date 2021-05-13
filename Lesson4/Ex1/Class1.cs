using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons4
{
    class Class1
    {
        public static void Static(int[] array)
        {
            int count = 0;
            for (int k = 0; k < (array.Length - 1); k++)
            {
                if ((array[k] % 3 == 0) || (array[k + 1] % 3 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine("\n" + "\n" + "Количество пар элементов массива, в которых только одно число делится на 3: " + count);
        }
    }
}