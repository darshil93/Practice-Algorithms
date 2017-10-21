using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromePairs
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static IList<IList<int>> PalindromePairs(string[] words)
        {
            IList<IList<int>> li = new List<IList<int>>();
            for(int i=0;i<words.Length;i++)
            {
                for(int j = 0; j < words.Length; j++)
                {
                    if (i != j)
                    {
                        if(checkPalindrome(words[i], words[j])) { li.Add(new List<int> { i, j }); }
                    }
                }
            }
            return li;
        }
        public static bool checkPalindrome(string m, string n)
        {
            string rev=new string (n.ToCharArray().Reverse().ToArray());
            if (m.Equals(rev)) { return true; }
            else { return false; }

        }
    }

    }
}
