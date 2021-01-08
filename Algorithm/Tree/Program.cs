using System.Collections.Generic;

namespace Tree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        #region 递归遍历

        public void Preorder(TreeNode root, IList<int> temp)
        {
            if (root == null) return;

            temp.Add(root.val);
            Preorder(root.left, temp);
            Preorder(root.right, temp);
        }

        public void Inorder(TreeNode root, IList<int> temp)
        {
            if (root == null) return;

            Inorder(root.left, temp);
            temp.Add(root.val);
            Inorder(root.right, temp);
        }

        public void PostOrder(TreeNode root, IList<int> temp)
        {
            if (root == null) return;

            PostOrder(root.left, temp);
            PostOrder(root.right, temp);
            temp.Add(root.val);
        }

        #endregion
    }
}