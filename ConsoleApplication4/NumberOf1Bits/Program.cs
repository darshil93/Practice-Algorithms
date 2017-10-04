using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            HammingWeight(2 (00000000000000000000000000000010));
        }
        public static int HammingWeight(uint n)
        {
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                count += (n >> i & 1) == 1 ? 1 : 0;
            }
            return count;
        }
    }
}
