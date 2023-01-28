using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
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
            string mixedString = "";
            for (int i = 0; i < a.Length + b.Length; i++)
            {
                mixedString = mixedString + a[i];
            }
            return mixedString;
        }
    }
}
