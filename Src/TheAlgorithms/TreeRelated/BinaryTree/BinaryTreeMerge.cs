namespace TheAlgorithms.TreeRelated.Merge
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BinaryTreeMerge
    {
        /// <summary>
        /// 2 binary tree will be merged and return new one
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public TreeNode Merge(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return null;
            }

            if (left == null && right != null)
            {
                return right;
            }

            if (left != null && right == null)
            {
                return left;
            }

            return new TreeNode(left.val + right.val)
            {
                left = Merge(left.left, right.left),
                right = Merge(left.right, right.right)
            };
        }
    }

    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode CreateT1()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(3);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(5);

            return root;
        }

        public static TreeNode CreteT2()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.right = new TreeNode(7);

            return root;
        }
    }
}
