using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_1_
{
    internal class Part_4
    {
        static void Main()
        {
            int[,] A =
            {
            {1,2},
            {3,4}
        };

            int[,] B =
            {
            {5,6},
            {7,8}
        };

            int number = 2;

            Console.WriteLine("Множення матриці A на число:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(A[i, j] * number + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nДодавання матриць:");

            int[,] sum = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = A[i, j] + B[i, j];
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nДобуток матриць:");

            int[,] mult = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        mult[i, j] += A[i, k] * B[k, j];
                    }

                    Console.Write(mult[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
