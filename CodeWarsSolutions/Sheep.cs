using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return (int) sheeps.Count(x => x == true);
        }
    }
}
