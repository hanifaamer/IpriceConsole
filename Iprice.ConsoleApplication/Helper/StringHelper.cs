using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iprice.Helper
{
    public class StringHelper
    {
        public static string ConvertStringIntoUpperLetter(string input)
        {
            return input.ToUpper();
        }

        public static string ConvertStringIntoSmallLetter(string input)
        {
            return input.ToLower();
        }

        public static List<char> SplitStringIntoListOfChar(string input)
        {
            return input.ToList();
        }

        public static string AlternateStringBetweenLowerUpper(string input)
        {
            string text = input.Replace(" ", "  ");
            string alternateStringBetweenLowerUpper = "";
            var firstLetterOfString = input[0].ToString();

            alternateStringBetweenLowerUpper += ConvertStringIntoSmallLetter(firstLetterOfString);

            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0)
                    alternateStringBetweenLowerUpper += ConvertStringIntoSmallLetter(text[i].ToString());
                else if (i % 2 != 0 && Char.IsLower(text[i]))
                    alternateStringBetweenLowerUpper += ConvertStringIntoUpperLetter(text[i].ToString());
                else
                    alternateStringBetweenLowerUpper += text[i];
            }

            return alternateStringBetweenLowerUpper.Replace("  ", " ");
        }

        public static string ConvertListOfCharToDelimitedString(List<char> input)
        {
            return string.Join(",", input);
        }
    }
}
