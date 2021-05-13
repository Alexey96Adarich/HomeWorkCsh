using System;
namespace lessons4_3
{
    internal class MyArrBase1
    {
        public int[] MainArray { get; set; }
        public MyArrBase1(int count, int start, int step)
        {
            MainArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                MainArray[i] = start;
                start += step;
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < MainArray.Length; i++)
                {
                    sum += MainArray[i];
                }
                return sum;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = MainArray[0];
                int count = 1;
                for (int i = 1; i < MainArray.Length; i++)
                {
                    if (MainArray[i] > max)
                    {
                        max = MainArray[i];
                        count = 1;
                    }
                    else if (MainArray[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public void Inverse()
        {
            for (int i = 0; i < MainArray.Length; i++)
            {
                MainArray[i] *= -1;
            }
        }
        public void Multi(int x)
        {
            for (int i = 0; i < MainArray.Length; i++)
            {
                MainArray[i] *= x;
            }
        }
        public void Print()
        {
            for (int i = 0; i < MainArray.Length; i++)
            {
                Console.Write("{0} ", MainArray[i]);
            }
            Console.WriteLine();
        }
    }
}