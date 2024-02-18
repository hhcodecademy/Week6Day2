using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionApp
{
    internal static class CustomExtension
    {
        public static int GetWordCount(this string text)
        {
            string[] words = text.Split(' ');
            int count = words.Length;
            return count;
        }
        public static int GetLetterCount(this string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsEven(this int number) 
        {
           
            if ((number % 2) == 0) 
            { 
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
