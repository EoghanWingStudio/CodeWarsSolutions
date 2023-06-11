using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class OddInt
    {
        public static int find_it(int[] ints)
        {
            return ints.GroupBy(x => x).Where(x => x.Count() % 2 != 0).Select(m => m.Key).FirstOrDefault();

        }
    }
}
