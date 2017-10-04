using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovesZerosToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0,0,1, 2, 3, 4};
            MoveZeroes(nums);
        }
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0) return;
            int count = 0;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
            }
            //int k = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]!=0)
                {
                    nums[k] = nums[i];
                    k++;
                }
                else 
                {
                    continue;
                }
            }
            for(int i=nums.Length-1;i>=nums.Length-count;i--)
            {
                nums[i] = 0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.ReadLine();
        }


    }
}
