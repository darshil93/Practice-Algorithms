using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> n = Subsets(new int[] {1,2,3});

        }
        public static List<List<int>> Subsets(int[] S)
        {
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>());

            List<int> n= S.ToList();
            n.Sort();
            foreach (int i in n)
            {
                List<List<int>> tmp = new List<List<int>>();
                foreach (List<int> sub in res)
                {
                    List<int> a = new List<int>(sub);
                    a.Add(i);
                    tmp.Add(a);
                }
                res.AddRange(tmp);
            }
            return res;

        }
    }
}
