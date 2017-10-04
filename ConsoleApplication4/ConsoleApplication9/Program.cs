/*Minimum Moves to Equal Array Elements by incrementing n-1 elments*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,4,3};
            Console.WriteLine(MinMoves(nums).ToString());
            Console.ReadLine();
        }
        public static int MinMoves(int[] nums)
        {
            int moves = 0;
            Array.Sort(nums);

            for(int i=nums.Length-1; i>0;i--)
            {
                moves += Math.Abs(nums[i] - nums[0]);
            }
            return moves;
        }
    }
}
