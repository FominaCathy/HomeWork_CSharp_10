using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_1
{
    //Задача 1. Даны два числа a, b.
    //Сложите их, используя только операции инкремента и декремента.

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = 53;
            int numberB = 4;

            Console.Write($"Сумма {numberA} и {numberB} = ");
            SummRecursion(numberA, numberB);
            
            Console.ReadLine();

            void SummRecursion(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine(a);
                    return;
                }
                a++;
                b--;
                SummRecursion(a, b);

            }
        }
    }
}
