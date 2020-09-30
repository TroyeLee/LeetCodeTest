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
    public class BinaryTreePostorderTraversalTests
    {
        [Test()]
        public void PostorderTraversalTest()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(3);
            root.right = node1;
            node1.left = node2;

            int[] expected = { 3, 2, 1 };
            IList<int> result = new BinaryTreePostorderTraversal().PostorderTraversal(root);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [Test()]
        public void PostorderTraversal2Test()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(3);
            root.right = node1;
            node1.left = node2;

            int[] expected = { 3, 2, 1 };
            IList<int> result = new BinaryTreePostorderTraversal().PostorderTraversal2(root);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}