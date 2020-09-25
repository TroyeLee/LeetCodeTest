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
    public class TopKFrequentElementsTests
    {
        [Test()]
        public void TopKFrequentTest()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            IList<int> expected = new List<int>() {1,2 };
            int[] result = new TopKFrequentElements().TopKFrequent(nums, k);

            Assert.AreEqual(expected.Count(), result.Length);
            foreach (var item in result)
            {
                Assert.IsTrue(expected.Contains(item));
                expected.Remove(item);
            }
        }

        [Test()]
        public void TopKFrequentTest02()
        {
            int[] nums = {1};
            int k = 1;
            IList<int> expected = new List<int>() { 1};
            int[] result = new TopKFrequentElements().TopKFrequent(nums, k);

            Assert.AreEqual(expected.Count(), result.Length);
            foreach (var item in result)
            {
                Assert.IsTrue(expected.Contains(item));
                expected.Remove(item);
            }
        }

        [Test()]
        public void TopKFrequentTest03()
        {
            int[] nums = { 1,2,2,2,3,3,4,5,5,2,4,4,4,5 };
            int k = 3;
            IList<int> expected = new List<int>() { 4,2, 5};
            int[] result = new TopKFrequentElements().TopKFrequent(nums, k);

            Assert.AreEqual(expected.Count(), result.Length);
            foreach (var item in result)
            {
                Assert.IsTrue(expected.Contains(item));
                expected.Remove(item);
            }
        }
    }
}