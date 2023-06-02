using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class DigitDigit
    {
        public static int SquareDigits(int n)
        {
            string numberString = n.ToString();
            List<int> numberList = numberString.Select(c => int.Parse(c.ToString())).ToList();
            string output = String.Empty;
            foreach (int c in numberList)
            {
                output += (c * c).ToString();
            }
            int numbers = 0;
            int.TryParse(output, out numbers);
            return numbers;
        }
    }
}