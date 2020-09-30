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
    public class RandomizedSetTests
    {
        [Test()]
        public void RandomizedSetTest()
        {
            RandomizedSet test = new RandomizedSet();
            bool result = test.Insert(1);
            Assert.IsTrue(result);

            result = test.Remove(2);
            Assert.IsFalse(result);

            result = test.Insert(2);
            Assert.IsTrue(result);

            int random = test.GetRandom();

            result = test.Remove(1);
            Assert.IsTrue(result);

            result = test.Insert(2);
            Assert.IsFalse(result);

            random = test.GetRandom();

        }

        public void RandomizedSetTest02()
        {
            RandomizedSet test = new RandomizedSet();
            bool result = test.Remove(0);
            Assert.IsFalse(result);

            result = test.Remove(0);
            Assert.IsFalse(result);

            result = test.Insert(0);
            Assert.IsTrue(result);

            int random = test.GetRandom();

            result = test.Remove(1);
            Assert.IsTrue(result);

            result = test.Insert(2);
            Assert.IsFalse(result);

            random = test.GetRandom();

        }
    }
}