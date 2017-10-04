using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestBSTTree
{
    public class  TreeNode
    {
        public int val;
        public TreeNode Node;
        public TreeNode left;
        public TreeNode right;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int LargestBSTSubtree(TreeNode root)
        {
            int sum=0;
            if (root == null)
            {
                return 0;
            }
            if(root.left.val<root.val && root.right.val>root.val)
            {
                if (root.left != null && root.right != null)
                    sum += 3;
            }
            return sum;
            
        }
    }
}
