using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;

//https://www.codewars.com/kata/59a9466f589d2af4c50001d8/train/csharp

namespace CodeWarsSolutionsTest
{
    public class NewDigitSymmetryTest
    {
        [TestFixture]
        public class BasicTests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(2, 1200).Returns(1);
                    //yield return new TestCaseData(2, 100000).Returns(247);
                    //yield return new TestCaseData(2, 1000000).Returns(2549);
                    //yield return new TestCaseData(100000, 1000000).Returns(2302);
                }
            }

            [Test, TestCaseSource("testCases")]
            public int Test(int min, int max) => NewDigitSymmatry.Solve(min, max);

        }
    }

}
