using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLinkedList
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsPalindrome(ListNode node)
        {
            if (node == null)
                return true;
            if (node.next == null)
                return true;
            Stack<ListNode> stack = new Stack<ListNode>();
            int count = 0;
            ListNode p = node;
            while (p != null)
            {
                count++;
                p = p.next;
            }

            p = node;
            int i = 0;
            while (p != null && i < count / 2)
            {
                stack.Push(p);
                p = p.next;
                i++;
            }
            if (count % 2 == 1)
            {
                p = p.next;
            }

            while (p != null)
            {
                ListNode q = stack.Pop();
                if (q.val != p.val)
                {
                    return false;
                }
                p = p.next;
            }

            return true;
        }

    }
}

