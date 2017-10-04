using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            AddDigits(38);
        }
        public static int AddDigits(int num)
        {
            int sum = num;
            do
            {
                sum = 0;
               while(num>0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                num = sum;
            } while (sum >= 10);
            return sum;
            // return 1 + (num - 1) % 9; // This is a single line solution
        }
    }
}
