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
    public class MaximumDepthOfBinaryTreeTests
    {
        [Test()]
        public void MaxDepthTest()
        {
            TreeNode root = new TreeNode(3);
            TreeNode node9 = new TreeNode(9);
            TreeNode node20 = new TreeNode(20);
            TreeNode node15 = new TreeNode(15);
            TreeNode node7 = new TreeNode(7);
            root.left = node9;
            root.right = node20;
            node20.left = node15;
            node20.right = node7;

            var result = new MaximumDepthOfBinaryTree().MaxDepth(root);

            int expected = 3;

            Assert.AreEqual(expected, result);
        }
    }
}