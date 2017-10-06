using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCount
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static int SparseBitcount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }
    }
}
