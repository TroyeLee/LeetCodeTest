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
    public class ConstructBinaryTreeFromPreorderAndInorderTraversalTests
    {
        [Test()]
        public void BuildTreeTest()
        {
            int[] inorder = { 9, 3, 15, 20, 7 };
            int[] preorder = { 3, 9, 20, 15, 7 };

            TreeNode result = new ConstructBinaryTreeFromPreorderAndInorderTraversal().BuildTree(preorder, inorder);


            var resultInorder = new BinaryTreeInorderTraversal().InorderTraversal(result);
            var resultPreorder = new BinaryTreePreorderTraversal().PreorderTraversal(result);

            Assert.AreEqual(inorder, resultInorder.ToArray<int>());
            Assert.AreEqual(preorder, resultPreorder.ToArray<int>());
        }
    }
}