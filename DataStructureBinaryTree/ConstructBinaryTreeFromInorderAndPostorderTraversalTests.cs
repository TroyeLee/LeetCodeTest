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
    public class ConstructBinaryTreeFromInorderAndPostorderTraversalTests
    {
        [Test()]
        public void BuildTreeTest()
        {
            int[] inorder = { 9, 3, 15, 20, 7 };
            int[] postorder = { 9, 15, 7, 20, 3 };

            TreeNode result = new ConstructBinaryTreeFromInorderAndPostorderTraversal().BuildTree(inorder,postorder);

            var resultInorder = new BinaryTreeInorderTraversal().InorderTraversal(result);
            var resultPostorder = new BinaryTreePostorderTraversal().PostorderTraversal(result);

            Assert.AreEqual(inorder, resultInorder.ToArray<int>());
            Assert.AreEqual(postorder, resultPostorder.ToArray<int>());


        }
    }
}