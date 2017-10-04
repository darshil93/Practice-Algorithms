using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthLargestElementUnsortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int FindKthLargest(int[] nums, int k)
        {
                List<int> n = nums.ToList<int>();
                n.Sort();
                int[] n1 = new int[n.Count];
                n1 = n.ToArray();
                return n1[n1.Length - k];

        }
    }
}
