using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProductSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int MaxProduct(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 0;
            }
            int max = A[0], min = A[0], result = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                int temp = max;
                max = Math.Max(Math.Max(max * A[i], min * A[i]), A[i]);
                min = Math.Min(Math.Min(temp * A[i], min * A[i]), A[i]);
                if (max > result)
                {
                    result = max;
                }
            }
            return result;
        }
    }
}
