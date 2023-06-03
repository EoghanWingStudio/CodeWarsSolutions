using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;

namespace CodeWarsSolutionsTest
{
    [TestFixture]
    public class OppositeNumbersTest
    {
        [Test]
        public void Test_1()
        {
            Assert.AreEqual(58000, OppositeNumbers.Opposite(-58000));
        }
    }
}
