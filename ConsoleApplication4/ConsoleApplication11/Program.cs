/*653. Two Sum IV - Input is a BST*/
//Given a Binary Search Tree and a target number, 
//return true if there exist two elements in the BST such that their sum is equal to the given target.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new TreeNode(2);
            tree.root.left = new TreeNode(1);
            tree.root.right = new TreeNode(3);
            tree.root.left.right = new TreeNode(4);
            Console.Write(FindTarget(tree.root, 4).ToString());
            Console.ReadLine();
        }
        public class BinaryTree
        {
            // Root of Binary Tree
            public TreeNode root;
            public BinaryTree(int key)      // Constructors
            {
                root = new TreeNode(key);
            }
            public BinaryTree()
            {
                root = null;
            }
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public static List<int> list = new List<int>();
        public static bool FindTarget(TreeNode root, int k)
        {

            inorder(root, list);
            int l = 0, r = list.Count - 1;
            while (l < r)
            {
                int sum = list.Find(item => item == l) + list.Find(item => item == r);
                if (sum == k)
                    return true;
                if (sum < k)
                    l++;
                else
                    r--;
            }
            return false;
        }
        public static void inorder(TreeNode root, List<int> list)
        {

            if (root == null)
            {

                return;
            }
            inorder(root.left, list);
            list.Add(root.val);
            inorder(root.right, list);
        }
    }
}
