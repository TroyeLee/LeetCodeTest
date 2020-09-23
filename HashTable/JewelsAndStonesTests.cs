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
    public class JewelsAndStonesTests
    {
        [Test()]
        public void NumJewelsInStonesTest()
        {
            string jewels = "Aa";
            string stones = "AAsdgaasea";
            int expected = 5;
            int result = new JewelsAndStones().NumJewelsInStones(jewels, stones);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void NumJewelsInStonesTest02()
        {
            string jewels = "ZZ";
            string stones = "z";
            int expected = 0;
            int result = new JewelsAndStones().NumJewelsInStones(jewels, stones);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void NumJewelsInStonesTest03()
        {
            string jewels = "Aa";
            string stones = "AAsdgaasea";
            int expected = 5;
            int result = new JewelsAndStones().NumJewelsInStones02(jewels, stones);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void NumJewelsInStonesTest04()
        {
            string jewels = "ZZ";
            string stones = "z";
            int expected = 0;
            int result = new JewelsAndStones().NumJewelsInStones02(jewels, stones);
            Assert.AreEqual(expected, result);
        }
    }
}