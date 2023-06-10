using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class Factorial
    {
        public static bool Narcissistic(int n)
        {
            List<int> intList = n.ToString().Select(o => Convert.ToInt32(o - 48)).ToList();
            int total = 0;
            foreach (int number in intList)
            {
                total += (int)Math.Pow(number, intList.Count);
            }

            return total == n;
        }
    }
}
