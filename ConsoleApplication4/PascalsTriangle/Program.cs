using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int64> res = new List<Int64>();
            res = GetRow(0).ToList<Int64>();
            Console.Read();

        }
        public static IList<int>  GetRow(int rowIndex)
        {
            List<long> res = new List<long>();
            long n = rowIndex;
            if (rowIndex == 0) { res.Add(1); return (IList<int>)res; }
            for (int line = 1; line <= n + 1; line++)
            {
                long C = 1;  // used to represent C(line, i)
                for (int i = 1; i <= line; i++)
                {
                    if (line == n + 1)
                    {
                        res.Add(C); // The first value in a line is always 1
                        C = C * (line - i) / i;
                    }
                }

            }
            return (IList<int>)res;
        }
    }
}
