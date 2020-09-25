using NUnit.Framework;
using LeetCode.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable.Tests
{
    [TestFixture()]
    public class _4sumIITests
    {
        [Test()]
        public void FourSumCountTest01()
        {
            int[] A = { 1, 2 };
            int[] B = { -2, -1 };
            int[] C = { -1, 2 };
            int[] D = { 0, 2 };
            int expected = 2;
            int result = new _4sumII().FourSumCount(A, B, C, D);

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void FourSumCountTest02()
        {
            int[] A = { 1, 2 };
            int[] B = { -2, -1 };
            int[] C = { -1, 2 };
            int[] D = { 0, 2 };
            int expected = 2;
            int result = new _4sumII().FourSumCount(A, B, C, D);

            Assert.AreEqual(expected, result);
        }
    }
}