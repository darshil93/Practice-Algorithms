using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHourAddDigitsUntil1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsHappy(int n)
        {
            int x = n;
            int y = n;
            while (x > 1)
            {
                x = cal(x);
                if (x == 1) return true;
                y = cal(cal(y));
                if (y == 1) return true;

                if (x == y) return false;
            }
            return true;
        }
        public static int cal(int n)
        {
            int x = n;
            int s = 0;
            while (x > 0)
            {
                s = s + (x % 10) * (x % 10);
                x = x / 10;
            }
            return s;
        }
    }
}
