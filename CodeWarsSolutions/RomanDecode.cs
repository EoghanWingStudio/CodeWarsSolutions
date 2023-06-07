using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class RomanDecode
    {
        public static int Solution(string roman)
        {
            char[] chars = roman.ToCharArray();
            int total = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if ((i + 1) < chars.Length)
                {
                    if (getNumericValue(chars[i].ToString()) < getNumericValue(chars[i + 1].ToString()))
                    {
                        total -= getNumericValue(chars[i].ToString());
                    }
                    else
                    {
                        total += getNumericValue(chars[i].ToString());
                    }
                }
                else
                {
                    total += getNumericValue(chars[i].ToString());
                }
            }

            return total;
        }

        private static int getNumericValue(string numeral)
        {
            switch (numeral)
            {
                case "I": return 1;
                case "V": return 5;
                case "X": return 10;
                case "L": return 50;
                case "C": return 100;
                case "D": return 500;
                case "M": return 1000;
                default: return 0;
            }
        }
    }
}
