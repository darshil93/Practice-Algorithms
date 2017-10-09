using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberMadeFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string LargestNumber(int[] nums)
        {
            
            if (nums.All(c => c == 0)) return "0";

            Array.Sort(nums, (a, b) => $"{b}{a}".CompareTo($"{a}{b}"));

            return string.Join("", nums);
        }
    }
}
