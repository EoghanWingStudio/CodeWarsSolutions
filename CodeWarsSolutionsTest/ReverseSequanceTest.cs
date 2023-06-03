using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;
namespace CodeWarsSolutionsTest
{
    //https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp
    [TestFixture]
    public class ReverseSequanceTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReverseSequence.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
        }
    }
}