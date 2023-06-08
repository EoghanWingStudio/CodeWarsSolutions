using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutionsTest
{
    public class MultiplesOf3and5Test
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, MultiplesOf3and5.Solution(10));
        }
    }
}
