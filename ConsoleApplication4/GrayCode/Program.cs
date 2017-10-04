using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayCode
{
    class Program
    {
        static void Main(string[] args)
        {
            GrayCode(3);   
        }
        public static void GrayCode(int n)
        {
            List<int> result = new List<int>();
            int x = 0>> 1;
            int y = 0 >> x;
            for (int i = 0; i < 1 << n; i++)
                result.Add(i ^ i >> 1);
            //return result;
        }
    }
}
