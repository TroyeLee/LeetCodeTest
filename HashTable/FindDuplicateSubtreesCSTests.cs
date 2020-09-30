using NUnit.Framework;
using LeetCode.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Domain;

namespace LeetCode.HashTable.Tests
{
    [TestFixture()]
    public class FindDuplicateSubtreesCSTests
    {
        [Test()]
        public void FindDuplicateSubtreesTest()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(3);
            TreeNode node3 = new TreeNode(4);
            TreeNode node4 = new TreeNode(2);
            TreeNode node5 = new TreeNode(4);
            TreeNode node6 = new TreeNode(4);
            root.left = node1;
            root.right = node2;
            node1.left = node3;
            node2.left = node4;
            node2.right = node5;
            node4.left = node6;

            IList<TreeNode> expected = new List<TreeNode>() { node3, node4 };

            IList<TreeNode> result = new FindDuplicateSubtreesCS().FindDuplicateSubtrees(root);

            
        }

        [Test()]
        public void FindDuplicateSubtreesTest02()
        {
            TreeNode root = new TreeNode(0);
            TreeNode node1 = new TreeNode(0);
            TreeNode node2 = new TreeNode(0);
            TreeNode node3 = new TreeNode(0);
            TreeNode node4 = new TreeNode(0);
            TreeNode node5 = new TreeNode(0);
            root.left = node1;
            root.right = node2;
            node1.left = node3;
            node2.right = node4;
            node4.right = node5;

            IList<TreeNode> expected = new List<TreeNode>() { node5};

            IList<TreeNode> result = new FindDuplicateSubtreesCS().FindDuplicateSubtrees(root);


        }
    }
}