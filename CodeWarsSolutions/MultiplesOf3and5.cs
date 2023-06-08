using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class MultiplesOf3and5
    {
        public static int Solution(int value)
        {
            int result = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0)
                {
                    result += i;
                    continue;
                }

                if (i % 5 == 0)
                {
                    result += i;
                    continue;
                }
            }
            return result;
        }
    }
}
