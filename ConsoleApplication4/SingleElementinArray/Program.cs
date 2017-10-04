using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleElementinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleNonDuplicate(new int[] {0, 1, 1});
        }
        public static int SingleNonDuplicate(int[] nums)
        {
            int n = nums.Length;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                flag = false;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] == nums[j]) { i = j; flag = true; }
                }
                if (flag == false)
                {
                    return nums[i];
                }
            }
            return nums[n - 1];

        }
    }
}
