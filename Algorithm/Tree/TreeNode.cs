//------------------------------------------------------------
// 作者: Nocye
// 日期: 2021年01月08日 星期五 17:07
//------------------------------------------------------------

using System.Collections.Generic;

namespace Tree
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int value, TreeNode l = null, TreeNode r = null)
        {
            val = value;
            left = l;
            right = r;
        }

        /// <summary>
        ///     根据一个数组创建一棵二叉树,同leetcode题目中的生成方式
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static TreeNode CreatBinaryTree(int[] arr)
        {
            var index = 0;
            var root = new TreeNode(arr[index++]);
            var queue = new Queue<TreeNode>(arr.Length);
            queue.Enqueue(root);
            TreeNode tempNode;
            while (arr.Length > index)
            {
                tempNode = queue.Dequeue();
                if (arr[index++] != -1 && tempNode != null)
                {
                    tempNode.left = new TreeNode(arr[index - 1]);
                    queue.Enqueue(tempNode.left);
                }
                else
                {
                    queue.Enqueue(null);
                }

                if (arr.Length > index && arr[index++] != -1 && tempNode != null)
                {
                    tempNode.right = new TreeNode(arr[index - 1]);
                    queue.Enqueue(tempNode.right);
                }
                else
                {
                    queue.Enqueue(null);
                }
            }

            queue.Clear();
            return root;
        }
    }
}