using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hammingDistance(1, 4).ToString());
            Console.ReadLine();
        }
        public  static int hammingDistance(int x, int y)
        {
            int count=0;
            int n = x ^ y;
            while(n>0)
            {
                count++;
                n &= n - 1;
            }
            return count;
        }
    }
}
