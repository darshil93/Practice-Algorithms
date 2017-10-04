/*Sample Binary Tree and Tree Traversal*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            /*create root*/
            tree.root = new Node(1);

            /* following is the tree after above statement

                  1
                /   \
              null  null     */

            tree.root.left = new Node(2);
            tree.root.right = new Node(3);

            /* 2 and 3 become left and right children of 1
                   1
                 /   \
                2      3
              /    \    /  \
            null null null null  */


            tree.root.left.left = new Node(4);
            /* 4 becomes left child of 2
                        1
                    /       \
                   2          3
                 /   \       /  \
                4    null  null  null
               /   \
              null null
             */
            tree.printPostorder(tree.root);
            Console.WriteLine();
            tree.printInorder(tree.root);
            Console.WriteLine();
            tree.printPreorder(tree.root);
            Console.ReadLine();
            tree.printLevelOrderbyQueue(tree.root);
            Console.ReadLine();

        }
    }
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
    public class BinaryTree
    {
        // Root of Binary Tree
        public Node root;

        // Constructors
        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null;
        }
        /* function to print level order traversal of tree*/
        public void printLevelOrder()
        {
            int h = height(root);
            int i;
            for (i = 1; i <= h; i++)
                printGivenLevel(root, i);
        }

        /* Compute the "height" of a tree -- the number of
        nodes along the longest path from the root node
        down to the farthest leaf node.*/
        public int height(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                /* compute  height of each subtree */
                int lheight = height(root.left);
                int rheight = height(root.right);

                /* use the larger one */
                if (lheight > rheight)
                    return (lheight + 1);
                else return (rheight + 1);
            }
        }

        /* Print nodes at the given level */
        public void printGivenLevel(Node root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
               Console.Write(root.key + " ");
        else if (level > 1)
            {
                printGivenLevel(root.left, level - 1);
                printGivenLevel(root.right, level - 1);
            }
        }
        public void printLevelOrderbyQueue(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count!=0)
            {

                /* poll() removes the present head.
                For more information on poll() visit 
                http://www.tutorialspoint.com/java/util/linkedlist_poll.htm */
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.key + " ");

                /*Enqueue left child */
                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                /*Enqueue right child */
                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }
        }

        public void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree
            printPostorder(node.left);

            // then recur on right subtree
            printPostorder(node.right);

            // now deal with the node
            Console.Write(node.key + " ");
           
        }
        public void printInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.Write(node.key + " ");

            /* now recur on right child */
            printInorder(node.right);
        }
        public void printPreorder(Node node)
        {
            if (node == null)
                return;

            /* then print the data of node */
            Console.Write(node.key + " ");

            /* first recur on left child */
            printInorder(node.left);

            /* now recur on right child */
            printInorder(node.right);
        }


    }
}
