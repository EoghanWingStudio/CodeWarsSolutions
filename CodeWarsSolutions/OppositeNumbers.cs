using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class OppositeNumbers
    {
        public static int Opposite(int number)
        {
            if (number < 0) return number * 1;

            else return number * -1;
        }
    }
}
