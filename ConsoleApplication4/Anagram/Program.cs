using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = IsAnagram("a", "a");
        }
        public static bool IsAnagram(string s, string t)
        {
            int[] alphabet = new int[26];
            for (int i = 0; i < s.Length; i++) alphabet[s[i] - 'a']++;
            for (int i = 0; i < t.Length; i++) alphabet[t[i] - 'a']--;
            foreach (int i in alphabet) if (i != 0) return false;
            return true;
        }
    }
}
