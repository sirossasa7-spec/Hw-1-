using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_1_
{
    internal class Part_6
    {
        static void Main()
        {
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine();

            char[] chars = text.ToLower().ToCharArray();

            bool newSentence = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (newSentence && char.IsLetter(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                    newSentence = false;
                }

                if (chars[i] == '.' || chars[i] == '!' || chars[i] == '?')
                {
                    newSentence = true;
                }
            }

            Console.WriteLine(new string(chars));
        }
    }
}
