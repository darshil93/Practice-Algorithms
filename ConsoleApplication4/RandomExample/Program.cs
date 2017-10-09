using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] ini;
        public Random rand;

        public Solution(int[] nums)
        {
            ini = nums;
            rand = new Random();
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return ini;
        }
        /** Returns aSrandom shuffling of the array. */
        public int[] Shuffle()
        {
            bool[] visited = new bool[ini.Length];
            int[] nums = new int[ini.Length];
            int index = 0;
            while (index < nums.Length)
            {
                int r = rand.Next(nums.Length);
                if (visited[r] == false)
                {
                    nums[index++] = ini[r];
                    visited[r] = true;
                }
            }
            return nums;
        }
    }
}
