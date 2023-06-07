using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp

namespace CodeWarsSolutionsTest
{
    [TestFixture]
    public class SplitStringTests
    {
        [TestCase(new string[] { "ab", "c_" }, "abc")]
        [TestCase(new string[] { "ab", "cd", "ef" }, "abcdef")]

        public void BasicTests(string[] result, string data)
        {
            Assert.AreEqual(result, SplitString.Solution(data));
        }
    }
}

