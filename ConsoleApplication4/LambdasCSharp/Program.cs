using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };
            var count = numbers.Where(c => c == 7).Count();

        }
    }
}
