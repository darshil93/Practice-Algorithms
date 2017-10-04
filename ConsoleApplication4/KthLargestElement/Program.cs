/* kth largest element*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public int FindKthLargest(int[] nums, int k)
        {
            List<int> num = new List<int>();
            num = nums.ToList<int>();
            //num.RemoveAll(x => x == 0);
            num.Sort();
            int count = 0;int res=0;
            for(int i=num.Count-1;i>=0;i--)
            {
                if(k==1)
                {
                    res= num[num.Count - 1];
                }
                else
                {
                    count++;
                    if (count == k)
                        res= num[i];
                }
                
            }
         
                return res;
            
        }
    }
}
