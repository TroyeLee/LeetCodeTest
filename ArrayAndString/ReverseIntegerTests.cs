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
    public class ReverseIntegerTests
    {
        [Test()]
        public void ReverseTest()
        {
            ReverseInteger test = new ReverseInteger();
            int nums = 123456;
            int expected = 654321;
            int result = test.Reverse(nums);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ReverseTest2()
        {
            ReverseInteger test = new ReverseInteger();
            int nums = 0;
            int expected = 0;
            int result = test.Reverse(nums);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void ReverseTest3()
        {
            ReverseInteger test = new ReverseInteger();
            int nums = -123456;
            int expected = -654321;
            int result = test.Reverse(nums);
            Assert.AreEqual(expected, result);
        }


        [Test()]
        public void ReverseTest4()
        {
            ReverseInteger test = new ReverseInteger();
            int nums = Int32.MaxValue;
            int expected = 0;
            int result = test.Reverse(nums);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void ReverseTest6()
        {
            ReverseInteger test = new ReverseInteger();
            int nums = Int32.MinValue;
            int expected = 0;
            int result = test.Reverse(nums);
            Assert.AreEqual(expected, result);
        }
    }
}