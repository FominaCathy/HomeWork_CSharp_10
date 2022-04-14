using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    //2. Дана монотонная последовательность,
    //в которой каждое натуральное число n
    //встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ...
    //Дано число m.
    //Выведите первые m членов этой последовательности.
    //m = 5 >> 1, 2, 2, 3, 3
    internal class Program
    {
        static void Main(string[] args)
        {

            RecurcyInput(5);
            Console.ReadLine();

            void RecurcyInput(int countNum, int count = 1)
            {
                if (countNum == 0) return;

                for (int i = 1; i < Math.Min(count, countNum)+1; i++)
                    Console.Write($"{count}, ");
                RecurcyInput(Math.Max(countNum -count,0), count+1);
            }
        }
    }
}
