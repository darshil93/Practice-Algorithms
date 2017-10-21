using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestConsecutiveSequenceOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestConsecutive(new int[] { 1, 2, 3, 4, 5, 6, 7, 10 });
        }
        public static int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            HashSet<int> setq = new HashSet<int>();

            foreach (int num in nums) setq.Add(num);
            int max = 1;
            foreach (int num in nums)
            {
                if (setq.Remove(num))
                {//num hasn't been visited
                    int val = num;
                    int sum = 1;
                    while (setq.Remove(val - 1)) val--;
                    sum += num - val;

                    val = num;
                    while (setq.Remove(val + 1)) val++;
                    sum += val - num;

                    max = Math.Max(max, sum);
                }
            }
            return max;
        }
    }
}
