using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTree
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(0);
            root.left = new Node(1);
            root.right = new Node(2);
            root.left.left = new Node(3);
            
        public static bool IsBalanced(Node root)
        {
            if (root == null)
            {
                return true;
            }
            return height(root) != -1;

        }
        public static int height(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            int lH = height(node.left);
            if (lH == -1)
            {
                return -1;
            }
            int rH = height(node.right);
            if (rH == -1)
            {
                return -1;
            }
            if (lH - rH < -1 || lH - rH > 1)
            {
                return -1;
            }
            return Math.Max(lH, rH) + 1;
        }
    }
}
