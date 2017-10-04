using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPalindrome(2).ToString());
            Console.ReadLine();
        }
        public static int LargestPalindrome(int n)
        {
            if (n == 1) return 9;
            int max = (int)Math.Pow(10, n) - 1;
            for (int v = max - 1; v > max / 10; v--)
            {
                long u = Convert.ToInt64((v.ToString() + new StringBuilder().Append(v)).Reverse().ToString());
                for (long x = max; x * x >= u; x--)
                    if (u % x == 0)
                        return (int)(u % 1337);
            }
            return 0;
        }
    }
}
