using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutionsTest
{
    public class CamelCaseTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("TestCase", CamelCase.GetCamelCase("test case"));
            Assert.AreEqual("CamelCaseMethod", "camel case method".GetCamelCase());
            Assert.AreEqual("SayHello", "say hello".GetCamelCase());
            Assert.AreEqual("CamelCaseWord", " camel case word".GetCamelCase());
            Assert.AreEqual("", "".GetCamelCase());
        }
    }
}
