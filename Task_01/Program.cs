using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    //1. Дано число n. Получите число, записанное в обратном порядке.
    //345 >> 543
    //81 >> 18
    internal class Program
    {

        static void Main(string[] args)
        {
            int number = 432101;
            int newNumber = 0;

            ReversNumber(number);
            Console.WriteLine($"начальное число= {number}; новое число {newNumber}");
            Console.ReadLine();

            int ReversNumber(int num)
            {
                if (num == 0)
                    return newNumber;

                newNumber = newNumber*10 + num % 10;

                return ReversNumber(num / 10);
            }
        }
    }
}
