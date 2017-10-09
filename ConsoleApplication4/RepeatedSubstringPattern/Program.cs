using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Incoorect solution
namespace RepeatedSubstringPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = RepeatedSubstringPattern("abcabcabc");
            Console.ReadLine();
        }
        public static bool RepeatedSubstringPattern(string s)
        {
            int n = s.Length;
            if (n % 2 != 0)
            {
                if (s.ToCharArray().Where(x => x == s[0]).Count() == n)
                    return true;
                else
                    return false;
            }
            string str = "";
            int k = n;
            for (int i = 0; i < n / 2; i++)
            {
                str = s.Substring(0, i + 1);
                string str1 = "";
                for (int j = 0; j < k; j++) { str1 += str; }
                if (s == str1) { return true; }
                k = k / 2;
                str = "";
            }

            return false;
        }
    }
}
