using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string bazaredString = "";
            for (int i = 0; i < input.Length; i = i + 2)
            {
                bazaredString += input[i];
            }
            for (int i = 1; i < input.Length; i = i + 2)
            {
                bazaredString += input[i];
            }
            return bazaredString;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return true;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (a == null || b == null || a == "" || b == "")
            {
                throw new ArgumentException();
            }

            for (int i = a.Length; i < b.Length; i++)
            {
                a += " ";
            }
            for (int i = b.Length; i < a.Length; i++)
            {
                b += " ";
            }

            string mixedString = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (!Char.IsWhiteSpace(a[i]))
                {
                    mixedString += (char)a[i];
                }
                if (!Char.IsWhiteSpace(b[i]))
                {
                    mixedString += (char)b[i];
                }
            }
            return mixedString;
        }

        public static string Reverse(string a)
        {
            string reversedString = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                reversedString += a[i];
            }
            return reversedString;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string saladString = "";
            for (int i = 0; i < input.Length; i++)
            {
                int help = input[i] + offset;
                if(help >= 91 && help <= 97 || help >= 123 && help <= 148)
                {
                    help -= 26;
                    saladString += (char)(help);
                }
                else if (help < 65 && help > 90 || help < 192 && help > 207 || help < 209 && help > 221)
                {
                    saladString += input[i];
                }
                else
                {
                    saladString += (char)(help);
                }
            }
            return saladString;
        }

        public static string ToLowerCase(string a)
        {
            string lowerString = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 65 && a[i] <= 90 || a[i] >= 192 && a[i] <= 207 || a[i] >= 209 && a[i] <= 221)
                {
                    lowerString += (char)(a[i] + 32);
                }
                else
                {
                    lowerString += (char)(a[i]);
                }
            }
            return lowerString;
        }

        public static string UnBazardString(string input)
        {
            string half1 = input.Substring(0, input.Length / 2);
            string half2 = input.Substring(input.Length / 2, input.Length / 2);


            //make sure both lengths are equal (impair lenght case)
            for (int i = half1.Length; i < half2.Length; i++)
            {
                half1 += " ";
            }
            for (int i = half2.Length; i < half1.Length; i++)
            {
                half2 += " ";
            }

            string straightnedString = "";
            for (int i = 0; i < half1.Length; i++)
            {
                straightnedString += $"{half1[i]}{half2[i]}";
            }
            return straightnedString;
        }

        public static string Voyelles(string a)
        {
            string result = "";

            Char[] Voyelle = new Char[] { 'A', 'I', 'U', 'E', 'O', 'Y', 'a', 'i', 'u', 'e', 'o', 'y' };
            foreach (char letter in a)
            {
                if (Char.IsLetter(letter))
                {
                    if (Voyelle.Contains(letter) && !result.Contains(letter))
                    {
                        result += letter;
                    }
                }
            }
            return ToLowerCase(result);
        }

    }
}
