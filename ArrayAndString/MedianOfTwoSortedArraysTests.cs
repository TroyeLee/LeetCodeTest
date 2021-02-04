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
    public class MedianOfTwoSortedArraysTests
    {
        [Test()]
        public void FindMedianSortedArraysTest()
        {
            MedianOfTwoSortedArrays test = new MedianOfTwoSortedArrays();
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2, 4 };
            double expected = 2.5;
            double result = test.FindMedianSortedArrays(nums1,nums2);

            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void FindMedianSortedArraysTest2()
        {
            MedianOfTwoSortedArrays test = new MedianOfTwoSortedArrays();
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 1 };
            double expected = 1;
            double result = test.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void FindMedianSortedArraysTest3()
        {
            MedianOfTwoSortedArrays test = new MedianOfTwoSortedArrays();
            int[] nums1 = new int[] { 2};
            int[] nums2 = new int[] {  };
            double expected = 2;
            double result = test.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void FindMedianSortedArraysTest4()
        {
            MedianOfTwoSortedArrays test = new MedianOfTwoSortedArrays();
            int[] nums1 = new int[] { 2 };
            int[] nums2 = new int[] { 1,3};
            double expected = 2;
            double result = test.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void FindMedianSortedArraysTest5()
        {
            MedianOfTwoSortedArrays test = new MedianOfTwoSortedArrays();
            int[] nums1 = new int[] { 0,0 };
            int[] nums2 = new int[] { 0, 0 };
            double expected = 0;
            double result = test.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, result);
        }
    }
}