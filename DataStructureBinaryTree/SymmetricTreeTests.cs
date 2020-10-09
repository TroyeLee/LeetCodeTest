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
    public class SymmetricTreeTests
    {
        [Test()]
        public void IsSymmetricTest()
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

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsSymmetricTest02()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(4);
            TreeNode node22 = new TreeNode(4);
            root.left = node10;
            root.right = node11;
            node10.left = node20;
            node10.right = node21;
            node11.left = node22;

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.IsFalse(result);
        }
        [Test()]
        public void IsSymmetricTest03()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(3);
            root.left = node10;
            root.right = node11;
            node10.right = node20;
            node11.right = node21;

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.IsFalse(result);
        }

        [Test()]
        public void IsSymmetricTest04()
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

            bool result = new SymmetricTree().IsSymmetricDFS(root);

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsSymmetricTest05()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(4);
            TreeNode node22 = new TreeNode(4);
            root.left = node10;
            root.right = node11;
            node10.left = node20;
            node10.right = node21;
            node11.left = node22;

            bool result = new SymmetricTree().IsSymmetricDFS(root);

            Assert.IsFalse(result);
        }
        [Test()]
        public void IsSymmetricTest06()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node10 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node20 = new TreeNode(3);
            TreeNode node21 = new TreeNode(3);
            root.left = node10;
            root.right = node11;
            node10.right = node20;
            node11.right = node21;

            bool result = new SymmetricTree().IsSymmetricDFS(root);

            Assert.IsFalse(result);
        }
    }
}