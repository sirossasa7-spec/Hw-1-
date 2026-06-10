using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_1_
{
    internal class Part_3
    {
        static string Encrypt(string text, int shift)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                result[i] = (char)(text[i] + shift);
            }

            return new string(result);
        }

        static string Decrypt(string text, int shift)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                result[i] = (char)(text[i] - shift);
            }

            return new string(result);
        }

        static void Main()
        {
            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();

            Console.Write("Зсув: ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = Encrypt(text, shift);

            Console.WriteLine($"Зашифровано: {encrypted}");
            Console.WriteLine($"Розшифровано: {Decrypt(encrypted, shift)}");
        }
    }
}
