using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 19
Дана целочисленная матрица A(NM). Найдите номер первой из ее строк, которые
начинаются с К положительных чисел подряд.*/

namespace _4_1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {   { 8, 0, -6, -4, 8 },
                { -4, 1, 6, 7, 8 },
                { 7, 8, 9, 1, -1 },
                { 12, 0, 3, 4, 5 }  };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            int k = 4;
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int j = 0; j < m-1; j++)
                {
                    if (arr[i, 0] > 0)
                    {
                        if ((arr[i, j] > 0) && (arr[i, j + 1] > 0))
                            count++;
                    }                    
                }
                if (count >= k)
                {
                    index = i;
                    goto Exit;
                }
            }
        Exit:
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
