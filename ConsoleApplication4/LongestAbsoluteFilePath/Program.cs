using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestAbsoluteFilePath
{
    class Program
    {
        static void Main(string[] args)
        {
            LengthLongestPath("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext");
        }
        public static int LengthLongestPath(string input)
        {


            String[] paths = Regex.Split(input, "\n");
            int[] stack = new int[paths.Length + 1];
            int maxLen = 0;
            foreach (String s in paths)
            {
                
                int lev = s.LastIndexOf("\t") + 1;
                int curLen = stack[lev + 1] = stack[lev] + s.Length - lev + 1;
                if (s.Contains(".")) maxLen = Math.Max(maxLen, curLen - 1);
            }
            return maxLen;
        }
    }
}
