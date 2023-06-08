using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutionsTest
{
    public class CamelCase2Test
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", CamelCase2.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", CamelCase2.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}
