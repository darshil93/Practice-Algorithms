using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string beginWord = "hit";
            string endWord = "cog";
            List<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            int n = LadderLength(beginWord, endWord, wordList);
            Console.WriteLine(n.ToString());
            Console.ReadLine();
        }
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            char[] b = beginWord.ToCharArray();
            char[] e = endWord.ToCharArray();
            int count = 0;
            if (beginWord == endWord)
                return 0;
            //if(wordList.Contains("hot"))
            //{
            //    count++;
            //}
            for (int i = 0; i < beginWord.Length; i++)
            {
                for (int j = 0; j < endWord.Length; j++)
                {
                    if (!(b[j] == e[j]))
                    {
                        char tmp = b[j];
                        b[j] = e[j];
                        string s = new string(b);
                        if (wordList.Contains(s))
                        {
                            count++;
                        }
                        else { b[j] = tmp; }
                    }
                }

            }
            return count;
        }
    }
}
