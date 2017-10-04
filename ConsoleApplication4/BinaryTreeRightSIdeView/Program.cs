using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeRightSIdeView
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        static void Main(string[] args)
        {
        }

        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null) return result;

            queue.Enqueue(root);
            while (queue.Count() != 0)
            {
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    if (i == 0) result.Add(cur.val);
                    if (cur.right != null) queue.Enqueue(cur.right);
                    if (cur.left != null) queue.Enqueue(cur.left);
                }

            }
            return result;

        }
    }
}
