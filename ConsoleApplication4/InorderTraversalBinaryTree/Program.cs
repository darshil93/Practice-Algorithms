using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InorderTraversalBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode currentNode = root;

            while (currentNode != null || stack.Count != 0)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.left;
                }

                if (stack.Count != 0)
                {
                    currentNode = stack.Pop();
                    result.Add(currentNode.val);
                    currentNode = currentNode.right;
                }
            }
        }
            
        return result;
    }
}
