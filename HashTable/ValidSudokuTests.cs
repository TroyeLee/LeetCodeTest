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
    public class ValidSudokuTests
    {
        [Test()]
        public void IsValidSudokuTest()
        {
            char[][] board = new char[][] { 
            new char[]{'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'} };
            bool expected = true;
            bool result = new ValidSudoku().IsValidSudoku(board);

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void IsValidSudokuTest02()
        {
            char[][] board = new char[][] {
            new char[]{'8', '3', '.', '.', '7', '.', '.', '.', '.'},
            new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'} };
            bool expected = false;
            bool result = new ValidSudoku().IsValidSudoku(board);

            Assert.AreEqual(expected, result);
        }
        public void IsValidSudokuTest03()
        {
            char[][] board = new char[][] {
            new char[]{'.', '.', '.', '.', '5', '.', '.', '1', '.'},
            new char[]{'.', '4', '.', '3', '.', '.', '.', '.', '.'},
            new char[]{'.', '.', '.', '.', '.', '3', '.', '.', '1'},
            new char[]{'8', '.', '.', '.', '.', '.', '.', '2', '.'},
            new char[]{'.', '.', '2', '.', '7', '.', '.', '.', '.'},
            new char[]{'.', '1', '5', '.', '.', '.', '.', '.', '.'},
            new char[]{'.', '.', '.', '.', '.', '2', '.', '.', '.'},
            new char[]{'.', '2', '.', '9', '.', '.', '.', '.', '.'},
            new char[]{'.', '.', '4', '.', '.', '.', '.', '.', '.'} };
            bool expected = false;
            bool result = new ValidSudoku().IsValidSudoku(board);

            Assert.AreEqual(expected, result);
        }
    }
}