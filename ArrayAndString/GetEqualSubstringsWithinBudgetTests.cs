using NUnit.Framework;
using LeetCode.ArrayAndString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString.Tests
{
    [TestFixture()]
    public class GetEqualSubstringsWithinBudgetTests
    {
        [Test()]
        public void EqualSubstringTest()
        {
            GetEqualSubstringsWithinBudget test = new GetEqualSubstringsWithinBudget();

            string s = "abcd";
            string t = "bcdf";
            int maxCost = 3;

            int expected = 3;
            int result = test.EqualSubstring(s, t, maxCost);

            Assert.AreEqual(expected, result);

        }


        [Test()]
        public void EqualSubstringTest2()
        {
            GetEqualSubstringsWithinBudget test = new GetEqualSubstringsWithinBudget();

            string s = "abcd";
            string t = "cdef";
            int maxCost = 3;

            int expected = 1;
            int result = test.EqualSubstring(s, t, maxCost);

            Assert.AreEqual(expected, result);

        }

        [Test()]
        public void EqualSubstringTest3()
        {
            GetEqualSubstringsWithinBudget test = new GetEqualSubstringsWithinBudget();

            string s = "abcd";
            string t = "acde";
            int maxCost = 0;

            int expected = 1;
            int result = test.EqualSubstring(s, t, maxCost);

            Assert.AreEqual(expected, result);

        }
    }
}