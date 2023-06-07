using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class CamelCase
    {
        public static string GetCamelCase(this string str)
        {
            string[] words = str.Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();

            string Result = string.Empty;

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                letters[0] = char.ToUpper(letters[0]);

                Result += new string(letters);
            }


            return Result;

        }
    }
}
