using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBoldTagToString
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBoldTag("abcxyz123", new string[]{"abc", "123"});
        }
        public static string AddBoldTag(string s, string[] dict)
        {
            int n = s.Length;
            int i = 0;
            bool[] marked = new bool[n];
            foreach (string word in dict)
            {
                int m = word.Length;
                for (i = 0; i <= n - m; i++)
                    if (s.Substring(i, m).Equals(word))
                        for (int j = i; j < i + m; j++) marked[j] = true;
            }

            i = 0;
            StringBuilder res = new StringBuilder();
            while (i < n)
            {
                if (marked[i])
                {
                    int j = i;
                    while (j < n && marked[j]) j++;
                    res.Append("<b>").Append(s.Substring(i, j-i)).Append("</b>");
                    i = j;
                }
                else res.Append(s[i++]);
            }

            return res.ToString();
        }
    }
}
