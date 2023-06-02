using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;
using CodeWarsSolutions;

namespace CodeWarsSolutionsTest
{

    [TestFixture]
    public class LoveTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, LoveDetector.lovefunc(1, 4));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, LoveDetector.lovefunc(2, 2));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, LoveDetector.lovefunc(0, 1));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, LoveDetector.lovefunc(0, 0));
        }
    }
}

