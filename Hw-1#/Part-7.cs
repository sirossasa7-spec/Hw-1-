using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_1_
{
    internal class Part_7
    {
        static void Main()
        {
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine();

            Console.Write("Неприпустиме слово: ");
            string badWord = Console.ReadLine();

            int count = 0;

            string stars = new string('*', badWord.Length);

            while (text.IndexOf(badWord,
                   StringComparison.OrdinalIgnoreCase) >= 0)
            {
                int index = text.IndexOf(
                    badWord,
                    StringComparison.OrdinalIgnoreCase);

                text = text.Remove(index, badWord.Length);
                text = text.Insert(index, stars);

                count++;
            }

            Console.WriteLine("\nРезультат:");
            Console.WriteLine(text);

            Console.WriteLine("\nСтатистика:");
            Console.WriteLine($"{count} заміни слова {badWord}");
        }
    }
}
