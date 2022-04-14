using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    //3. Дано натульное число n > 1. Вывести все простые множители данного числа.
    //10 >> 5, 2.
    //12 >> 2, 2, 3.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numm = 100;

            SimpleNumber(numm);
            Console.ReadLine();

            void SimpleNumber(int number, int simple =2)
            {
                if (number == 1) return;

                if (number % simple == 0)
                {
                    Console.Write($"{simple}, ");
                    SimpleNumber(number / simple, simple);
                }
                else
                    SimpleNumber(number, simple + 1);
            }
        }
    }
}
