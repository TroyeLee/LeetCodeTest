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
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Test()]
        public void LengthOfLongestSubstringTest()
        {
            string s = "abcdaxabcabcdefgh";
            int expected = 8;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest02()
        {
            string s = "";
            int expected = 0;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest03()
        {
            string s = "abcabcbb";
            int expected = 3;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest04()
        {
            string s = "bbbb";
            int expected = 1;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void LengthOfLongestSubstringTest05()
        {
            string s = "pwwkew";
            int expected = 3;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void LengthOfLongestSubstringTest06()
        {
            string s = " ";
            int expected = 1;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest07()
        {
            string s = "abcdaxabcabcdefgh";
            int expected = 8;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring02(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest08()
        {
            string s = "";
            int expected = 0;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring02(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest09()
        {
            string s = "abcabcbb";
            int expected = 3;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring02(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void LengthOfLongestSubstringTest10()
        {
            string s = "bbbb";
            int expected = 1;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring02(s);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void LengthOfLongestSubstringTest11()
        {
            string s = "pwwkew";
            int expected = 3;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring02(s);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void LengthOfLongestSubstringTest12()
        {
            string s = " ";
            int expected = 1;
            int result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring02(s);
            Assert.AreEqual(expected, result);
        }


    }
}