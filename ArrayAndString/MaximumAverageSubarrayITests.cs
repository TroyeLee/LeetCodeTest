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
    public class MaximumAverageSubarrayITests
    {
        [Test()]
        public void FindMaxAverageTest()
        {
            MaximumAverageSubarrayI test = new MaximumAverageSubarrayI();
            int[] nums = new int[] { 1, 12, -5, -6, 50, 3 };
            int k = 4;

            double expected = 12.75;

            double result = test.FindMaxAverage(nums, k);

            Assert.AreEqual(expected, result);
        }


        [Test()]
        public void FindMaxAverageTest2()
        {
            MaximumAverageSubarrayI test = new MaximumAverageSubarrayI();
            int[] nums = new int[] { 1, 12, -5, -6, 50, 3, 83, -30, -10, 20, 37 };
            int k = 4;

            double expected = 32.5;

            double result = test.FindMaxAverage(nums, k);

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void FindMaxAverageTest3()
        {
            MaximumAverageSubarrayI test = new MaximumAverageSubarrayI();
            int[] nums = new int[] {5 };
            int k = 1;

            double expected = 5;

            double result = test.FindMaxAverage(nums, k);

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void FindMaxAverageTest4()
        {
            MaximumAverageSubarrayI test = new MaximumAverageSubarrayI();
            int[] nums = new int[] { -1 };
            int k = 1;

            double expected = -1;

            double result = test.FindMaxAverage(nums, k);

            Assert.AreEqual(expected, result);
        }


    }
}