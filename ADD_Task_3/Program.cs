using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_3
{
    //Задача 3. Дан массив, состоящий из случайных целых чисел.
    //Дано число M. Выведите случайное подмножество массива,
    //сумма элементов в котором не превосходит M.
    //{11, 52, 36, 8, 19}, M = 50 >> 11, 19, 8
    //{ 11, 52, 36, 8, 19}, M = 50 >> 36, 8

    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = { 10, 98, 36, 4, 30, 69, 12};
            int numberM = 81;
            int ind = 0;


            List<int> subarray = new List<int>(); 
            for (int i = 0; i < array.Length; i++)
                if (array[i] <= numberM)
                {
                    subarray.Add(array[i]);
                }
            Random rnd = new Random();

            Recursion(subarray, numberM);

            Console.ReadLine();

            void Recursion(List<int> subArr, int numm)
            {
                if ((subArr.Count == 0) || (numm <= 0)) return;

                ind = rnd.Next(0, subArr.Count);

                if (subArr[ind] <= numm)
                {
                    Console.Write($"{subArr[ind]}, ");
                    numm -= subArr[ind];
                }

                subArr.Remove(subArr[ind]);
                Recursion(subArr, numm);
            }

        }
    }
}
