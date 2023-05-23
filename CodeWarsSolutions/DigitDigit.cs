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
            char[] digits = n.ToString().ToCharArray();   
            string numbers = "";    

            foreach (char c in digits)
            {
                int nDigit = Convert.ToInt32(c);
                +numbers += (c * c).ToString(); 
            }
            int number;
            int.TryParse(numbers, out number);
            return number;
        }
    }
}