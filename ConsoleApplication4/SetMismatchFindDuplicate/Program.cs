using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMismatchFindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2,2,4 };
            int[] res = FindErrorNums(nums);
        }
        public static int[] FindErrorNums(int[] nums)
        {
            int[] res = new int[2];
            
            int[] count = new int[nums.Length +1];
            foreach (var i in nums)
                count[i] += 1;
            for (int i = 1; i <=nums.Length; i++)
            {
                if (count[i] == 2)
                    res[0] =i;
                else if (count[i] == 0)
                    res[1]=i;
            }

            return res.ToArray<int>();
        }
    }
}
