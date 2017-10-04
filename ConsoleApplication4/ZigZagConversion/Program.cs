using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("ABC", 2));
            Console.ReadLine();
        }
        public static string Convert(String s, int numRows)
        {
            if (numRows <= 1) return s;
            StringBuilder[] sb = new StringBuilder[numRows];
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i] = new StringBuilder("");   
            }
            int incre = 1;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sb[index].Append(s[i]);
                if (index == 0) { incre = 1; }
                if (index == numRows - 1) { incre = -1; }
                index += incre;
            }
            string re = "";
            for (int i = 0; i < sb.Length; i++)
            {
                re += sb[i];
            }
            return re.ToString();

        }
    }
}
