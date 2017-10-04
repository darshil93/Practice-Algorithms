using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeSum(new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 });
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> n = nums.ToList<int>();
            n.Sort();
            if (nums.Length < 1) return res;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && n[i] == n[i - 1])
                {              // skip same result
                    continue;
                }
                int sum = n[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum = n[i] + n[j];
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        sum += n[k];
                        if (sum == 0)
                        {
                            List<int> temp = new List<int>();
                            temp.Add(n[i]); temp.Add(n[j]); temp.Add(n[k]);
                            bool flag = false;

                            if (flag == false) { res.Add(temp); }
                        }
                        else
                        {
                            sum -= n[k];
                        }
                    }
                }
            }
            //IList<IList<int>> res1 = new List<IList<int>>();
            //for (int i = 0; i < res.Count; i++)
            //{
            //    if (!res1.Contains(res[i]))
            //        res1.Add(res[i]);
            //}
            return res;
        }
    }
}
