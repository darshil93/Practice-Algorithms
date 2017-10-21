using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            TopKFrequent(new int[] { 1, 2, 2, 3, 4, 5, 6, 5 }, 2);
        }
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            IList<int> li = new List<int>();
            Array.Sort(nums);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 0);
                }
            }
            var items = from pair in dict
                        orderby pair.Value descending
                        select pair;    
            foreach(var i in items)
            {
                if (k > 0)
                {
                    li.Add(i.Key);
                    k--;
                }
            }
            return li;

        }
    }
}
