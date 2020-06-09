using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernyak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Черняк Оксана Александровна, АЭМ-111");
            Console.Write("Введите размер матрицы: ");

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matrix[i, j] = j - i + 1;
                    matrix[j, i] = j - i + 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //форматироваие до 2 символов занимая либо 1 либо 2 цифры
                    Console.Write("{0,2:##} ", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}