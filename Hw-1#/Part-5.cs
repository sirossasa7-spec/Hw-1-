using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_1_
{
    internal class Part_5
    {
        static void Main()
        {
            Console.Write("Введіть вираз: ");
            string expr = Console.ReadLine().Replace(" ", "");

            int result = 0;
            string number = "";
            char operation = '+';

            foreach (char c in expr)
            {
                if (char.IsDigit(c))
                {
                    number += c;
                }
                else
                {
                    int value = int.Parse(number);

                    if (operation == '+')
                        result += value;
                    else
                        result -= value;

                    operation = c;
                    number = "";
                }
            }

            int last = int.Parse(number);

            if (operation == '+')
                result += last;
            else
                result -= last;

            Console.WriteLine($"Результат = {result}");
        }
    }
}
