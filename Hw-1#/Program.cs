namespace Hw_1_
{
    internal class Program
    {
        static void Main()
        {
            //int[] A = new int[5];
            //double[,] B = new double[3, 4];
            //Random rnd = new Random();

            //Console.WriteLine("Введіть 5 елементів масиву A:");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"A[{i}] = ");
            //    A[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        B[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
            //    }
            //}

            //Console.WriteLine("\nМасив A:");
            //foreach (int item in A)
            //    Console.Write(item + " ");

            //Console.WriteLine("\n\nМасив B:");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{B[i, j],8}");
            //    }
            //    Console.WriteLine();
            //}

            //double max = A[0];
            //double min = A[0];
            //double sum = 0;
            //double product = 1;

            //int sumEvenA = 0;
            //double sumOddColumnsB = 0;

            //foreach (int item in A)
            //{
            //    if (item > max) max = item;
            //    if (item < min) min = item;

            //    sum += item;
            //    product *= item;

            //    if (item % 2 == 0)
            //        sumEvenA += item;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (B[i, j] > max) max = B[i, j];
            //        if (B[i, j] < min) min = B[i, j];

            //        sum += B[i, j];
            //        product *= B[i, j];

            //        if (j % 2 == 0)
            //            sumOddColumnsB += B[i, j];
            //    }
            //}

            //Console.WriteLine($"\nМаксимум = {max}");
            //Console.WriteLine($"Мінімум = {min}");
            //Console.WriteLine($"Сума = {sum}");
            //Console.WriteLine($"Добуток = {product}");
            //Console.WriteLine($"Сума парних елементів A = {sumEvenA}");
            //Console.WriteLine($"Сума непарних стовпців B = {sumOddColumnsB}");

            int[,] arr = new int[5, 5];
            Random rnd = new Random();

            int min = 101, max = -101;
            int minPos = 0, maxPos = 0;

            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(-100, 101);

                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minPos = index;
                    }

                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxPos = index;
                    }

                    Console.Write($"{arr[i, j],5}");
                    index++;
                }
                Console.WriteLine();
            }

            int start = Math.Min(minPos, maxPos);
            int end = Math.Max(minPos, maxPos);

            int sum = 0;
            index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (index > start && index < end)
                        sum += arr[i, j];

                    index++;
                }
            }

            Console.WriteLine($"\nСума між min та max = {sum}");
        }
    }
}
