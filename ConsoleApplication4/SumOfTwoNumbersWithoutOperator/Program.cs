using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbersWithoutOperator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int GetSum(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            int sum, carry;
            sum = a ^ b;
            carry = (a & b) << 1;
            return GetSum(sum, carry);//
        }
    }
}
