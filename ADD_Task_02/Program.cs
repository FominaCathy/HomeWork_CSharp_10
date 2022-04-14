using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_02
{
    //Задача 2. Дана последовательность натуральных чисел.
    //Определите значение второго по величине элемента в этой последовательности.
    //{1, 2, 3, 4, 5} >> 4
    //{ 7, 4, 2, 7, 6, 6, 8} >> 7

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 4, 2, 7, 6, 6, 9, 8 };
            int maxFirst = 0;
            int maxSecond = 0;

            SecondMax(array);
            Console.ReadKey();

            void SecondMax(int[] arr, int count = 0)
            {
                if (count == arr.Length)
                {
                    Console.WriteLine($"второй по величине элемент = {maxSecond}");
                    return;
                }

                if (maxFirst < arr[count])
                {
                    maxSecond = maxFirst;
                    maxFirst= arr[count];
                }
                else if (maxSecond < arr[count]) maxSecond = arr[count];

                SecondMax (arr, count +1);

            }

        }
    }
}
