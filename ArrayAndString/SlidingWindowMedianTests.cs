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
    public class SlidingWindowMedianTests
    {
        [Test()]
        public void MedianSlidingWindowTest()
        {
            SlidingWindowMedian test = new SlidingWindowMedian();
            int[] nums = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            double[] expected = new double[] { 1, -1, -1, 3, 5, 6 };

            double[] result = test.MedianSlidingWindow(nums,k);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }
    }
}