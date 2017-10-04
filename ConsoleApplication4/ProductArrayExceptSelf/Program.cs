using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            var b = ProductExceptSelf(a);
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            res[0] = 1;
            for (int i = 1; i < n; i++)
            {
                res[i] = res[i - 1] * nums[i - 1];
            }
            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                res[i] *= right;
                right *= nums[i];
            }
            return res;
        }
    }
}
