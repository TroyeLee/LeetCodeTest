using NUnit.Framework;
using LeetCode.DataStructureBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Domain;

namespace LeetCode.DataStructureBinaryTree.Tests
{
    [TestFixture()]
    public class PathSumTests
    {
        [Test()]
        public void HasPathSumTest()
        {
            TreeNode root = null;

            int sum = 0;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsFalse(result);

        }
        [Test()]
        public void HasPathSumTest01()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(4);
            TreeNode node22 = new TreeNode(4);
            TreeNode node23 = new TreeNode(3);
            root.left = node10;
            root.right = node11;
            node10.left = node20;
            node10.right = node21;
            node11.left = node22;
            node11.right = node23;

            int sum = 6;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsTrue(result);

        }

        [Test()]
        public void HasPathSumTest02()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            root.left = node10;
            root.right = node11;

            int sum = 4;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsFalse(result);

        }
        [Test()]
        public void HasPathSumTest03()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(4);
            TreeNode node30 = new TreeNode(4);
            TreeNode node31 = new TreeNode(3);
            root.left = node10;
            root.right = node11;
            node10.left = node20;
            node10.right = node21;
            node21.left = node30;
            node21.right = node31;

            int sum = 10;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsTrue(result);

        }
        [Test()]
        public void HasPathSumTest04()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(4);
            TreeNode node30 = new TreeNode(4);
            TreeNode node31 = new TreeNode(3);
            root.left = node10;
            root.right = node11;
            node10.left = node20;
            node10.right = node21;
            node21.left = node30;
            node21.right = node31;

            int sum = 6;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsTrue(result);

        }

        [Test()]
        public void HasPathSumTest05()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(4);
            TreeNode node30 = new TreeNode(4);
            TreeNode node31 = new TreeNode(3);
            root.left = node10;
            root.right = node11;
            node10.left = node20;
            node10.right = node21;
            node21.left = node30;
            node21.right = node31;

            int sum = 5;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsFalse(result);

        }


        [Test()]
        public void HasPathSumTest06()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            root.left = node10;

            int sum = 1;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsFalse(result);

        }

        [Test()]
        public void HasPathSumTest07()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            root.right = node10;

            int sum = 1;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsFalse(result);

        }

        [Test()]
        public void HasPathSumTest08()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            root.right = node10;

            int sum = 3;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsTrue(result);

        }

        [Test()]
        public void HasPathSumTest09()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            root.right = node10;

            int sum = 2;
            bool result = new PathSum().HasPathSum(root, sum);

            Assert.IsFalse(result);

        }
    }
}