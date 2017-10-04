using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 3, 4 };
            int[] res = TwoSum(nums, 0);
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int sum = 0;
            int[] res = new int[2];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i+1; j < numbers.Length; j++)
            //    {
            //        sum = numbers[i] + numbers[j];
            //        if (sum == target)
            //        { res[0] = j + 1;
            //            res[1] = i + 1;
            //            return res;
            //        }
            //    }
            //}
            //return res;

            int hi = 0; int lo = numbers.Length - 1;

            while ((numbers[lo] + numbers[hi] != target))
            {
                if (numbers[lo] + numbers[hi] < target)
                {
                    lo++;
                }
                else
                {
                   hi--; 
                }
            }
            res[0] = hi + 1; res[1] = lo + 1;
            return res;

        }
    }
}
