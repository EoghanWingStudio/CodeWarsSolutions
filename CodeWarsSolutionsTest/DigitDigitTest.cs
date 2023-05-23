using CodeWarsSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutionsTest
{
    [TestFixture]

    public class DigitDigitTest
    {
        [Test]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, DigitDigit.SquareDigits(9119));
            Assert.AreEqual(0, DigitDigit.SquareDigits(0));
        }
    }
}
