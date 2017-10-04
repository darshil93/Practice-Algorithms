using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinationsofPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = LetterCombinations("123");
        }
        public static IList<string> LetterCombinations(string digits)
        {
            Queue<string> ans = new Queue<string>();
            String[] mapping = new String[] { "0", " ", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            ans.Enqueue("");
            for (int i = 0; i < digits.Length; i++)
            {
                int x = (int)char.GetNumericValue(digits[i]);
                while (ans.Peek().Length == i)
                {
                    string t = ans.Dequeue();
                    foreach (char s in mapping[x].ToCharArray())
                        ans.Enqueue(t + s);
                }
            }
            return ans.ToList();
        }
    }
}
