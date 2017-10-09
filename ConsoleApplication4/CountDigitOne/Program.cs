using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigitOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CountDigit1(13);
            Console.ReadLine();
        }
        public static int CountDigit1(int n)
        {
            int count = 0;
            for(int i = 1; i < n; i++)
            {
                //count += countno(i);
                count+=i.ToString().Where(x => x == '1').Count();
            }
            return count;
        }
 
        
    }
}
