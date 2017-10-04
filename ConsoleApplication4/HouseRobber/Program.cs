using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRobber
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Rob(new int[] { 12, 0, 24, 56, 112 });
            Dictionary<int, int> d = new Dictionary<int, int>();
            
        }
        public static int Rob(int[] num)
        {
            int rob = 0; //max monney can get if rob current house
            int notrob = 0; //max money can get if not rob current house
            for (int i = 0; i < num.Length; i++)
            {
                int currob = notrob + num[i]; //if rob current value, previous house must not be robbed
                notrob = Math.Max(notrob, rob); //if not rob ith house, take the max value of robbed (i-1)th house and not rob (i-1)th house
                rob = currob;
            }
            return Math.Max(rob, notrob);
        }
    }
}
