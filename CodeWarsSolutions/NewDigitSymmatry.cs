using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class NewDigitSymmatry
    {
        public static int Solve(int min, int max)
        {
            List<int> conditionMet = new List<int>();

            for (int i = min; i <= max; i++)
            {
                if (!checkFirstTwoForPrime(i)) continue;

                int square = i * i;

                if (!checkFirstTwoForPrime(square)) continue;

                if (!lastTwoDigitsMatch(i, square)) continue;
                conditionMet.Add(i);



            }

            return conditionMet.Count;
        }

        static bool checkFirstTwoForPrime(int n)
        {
            string numberString = n.ToString();
            List<int> numberList = numberString.Select(c => int.Parse(c.ToString())).ToList();

            for (int j = 0; j <= 2; j++)
            {
                if (numberList.Count < 2) return false;

                if (numberList.Count <= j) return false;

                if (!isPrime(numberList[j])) return false;


            }
            return true;
        }

        static bool isPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;

        }

        static bool lastTwoDigitsMatch(int original, int square)
        {

            return (original % 100) == (square % 100);
        }
    }
}
