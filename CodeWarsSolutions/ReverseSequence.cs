using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class ReverseSequence
    {
        public static int[] ReverseSeq(int n)
        {
            int[] result = new int[n];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = n - i;
            }
            return result;
        }
    }
}
