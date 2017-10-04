using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElementII
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static IList<int> MajorityElement(int[] nums)
        {
            IList<int> list = new List<int>();
            int major = nums[0]; int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    major = nums[i];
                    count++;
                }
                else if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count > (nums.Length/ 3))
                    list.Add(nums[i]);
            }
            return list;
        }
    }
}
