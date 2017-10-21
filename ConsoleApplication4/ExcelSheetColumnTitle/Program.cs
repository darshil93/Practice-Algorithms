using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetColumnTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToTitle(27);

        }
        public static string ConvertToTitle(int n)
        {
            StringBuilder result = new StringBuilder();

            while (n > 0)
            {
                n--;
                result.Insert(0, (char)('A' + n % 26));
                n /= 26;
            }
            return result.ToString();

        }
    }
}
