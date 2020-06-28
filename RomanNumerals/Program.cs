using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    class Program
    {
        static string RomanNumeralsTranslator(string romanNumber)
        {
            char[] romanNumberArray = romanNumber.ToCharArray();

            var romanArabicDictionary = new Dictionary<char, int>()
            {
                {'i', 1 },
                {'v', 5 },
                {'x', 10 },
            };
            
            int arabicNumber = 0;

            for (int i = 0; i < romanNumberArray.Length; i++)
            {
                if (i + 1 < romanNumberArray.Length
                    && isSubtractive(romanArabicDictionary[romanNumberArray[i]],
                    romanArabicDictionary[romanNumberArray[i + 1]]))
                {
                    arabicNumber -= romanArabicDictionary[romanNumberArray[i]];
                }
                else
                {
                    arabicNumber += romanArabicDictionary[romanNumberArray[i]];
                }
            }

            return $"{arabicNumber}";
        }


        static bool isSubtractive(int number1, int number2)
        {
            return number1 < number2;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter roman number");
                string romanNumber = Console.ReadLine();

                Console.WriteLine(RomanNumeralsTranslator(romanNumber));
            }
        }
    }
}
