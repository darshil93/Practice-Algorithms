using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListRemoveNthNodefromLast
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            int length = 0;
            ListNode first = head;
            while (first != null)
            {
                length++;
                first = first.next;
            }
            length -= n;
            first = dummy;
            while (length > 0)
            {
                length--;
                first = first.next;
            }
            first.next = first.next.next;
            return dummy.next;
        }
    }
}
