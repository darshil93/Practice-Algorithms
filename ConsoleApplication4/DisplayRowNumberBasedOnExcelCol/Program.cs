using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRowNumberBasedOnExcelCol
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleToNumber("AABB");
        }
        public static int TitleToNumber(String s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result = result * 26 + (s[i] - 'A' + 1);
            }
            return result;
        }
    }
}
