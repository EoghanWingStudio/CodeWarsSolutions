
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutionsTest
{
    [TestFixture]
    public class RomanDecodeTests
    {
        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(1954, "MCMLIV")]
        public void Test(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }
    }
}
