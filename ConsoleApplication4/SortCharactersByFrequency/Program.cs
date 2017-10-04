using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCharactersByFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(FrequencySort("aabcccd"));
            Console.ReadLine();
        }
        public static string FrequencySort(string s)
        {
            #region dasd
            //    int[] a = new int[256];
            //    Dictionary<char , int> dict = new Dictionary<char, int>();
            //    string res="";
            //    for(int i = 0; i < s.Length; i++)
            //    {
            //        dict.Add(s[i], 0);
            //    }
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        dict[s[i]]++;
            //    }
            //    for (int i=0;i<s.Length;i++)
            //    {
            //        int n =a.Max();
            //        for(int j=255; j>0;j--)
            //        {
            //            if (a[j] == n)
            //            {
            //                res += (char)j;
            //                a[j]--;
            //                break;
            //            }
            //        }

            //    }
            //    return res;
            #endregion

            if (s.Length < 3)
                return s;
            int max = 0;
            int[] map = new int[256];
            foreach (char ch in s.ToCharArray())
            {
                map[ch]++;
                max = Math.Max(max, map[ch]);
            }
            String[] buckets = new String[max + 1]; // create max buckets
            for (int i = 0; i < 256; i++)
            { // join chars in the same bucket
                String str = buckets[map[i]];
                if (map[i] > 0)
                    buckets[map[i]] = (str == null) ? "" + (char)i : (str + (char)i);
            }
            StringBuilder strb = new StringBuilder();
            for (int i = max; i >= 0; i--)
            { // create string for each bucket.
                if (buckets[i] != null)
                    foreach (char ch in buckets[i].ToCharArray())
                        for (int j = 0; j < i; j++)
                            strb.Append(ch);
            }
            return strb.ToString();
        }
    }
}
