using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private Dictionary<string, List<int>> map;

        public void WordDistance(String[] words)
        {
            map = new Dictionary<string, List<int>>();
            for (int i = 0; i < words.Length; i++)
            {
                String w = words[i];
                if (map.ContainsKey(w))
                {
                    List<int> tmp = new List<int>();
                    map.TryGetValue(w, out tmp);
                    map.Add(w, tmp);

                }
                else
                {
                    List<int> list = new List<int>();
                    list.Add(i);
                    map.Add(w, list);
                }
            }
        }

        public int shortest(String word1, String word2)
        {
            List<int> tmp = new List<int>();
            List<int> list1 = new List<int>();
            map.TryGetValue(word1, out list1);
            List<int> list2 = new List<int>();
            map.TryGetValue(word2, out list2);
            int ret = int.MaxValue;
            for (int i = 0, j = 0; i < list1.Count && j < list2.Count;)
            {
                int index1=list1.IndexOf(i), index2 = list2.IndexOf(j);
                if (index1 < index2)
                {
                    ret = Math.Min(ret, index2 - index1);
                    i++;
                }
                else
                {
                    ret = Math.Min(ret, index1 - index2);
                    j++;
                }
            }
            return ret;
        }
    }
}
