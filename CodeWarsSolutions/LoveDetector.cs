using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class LoveDetector
    {
        public static bool lovefunc(int v1, int v2)
        {
            return !((v1%2) == (v2%2));

        }
    }
}
