using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Reverses individual words in a string
namespace ReverseWordsInaString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ReverseWords("   a   b "));
            Console.ReadLine();
        }
        public static string ReverseWords(string s)
        {
            string[] parts = s.Trim().Split(' ');
            string output = "";
            for (int i = parts.Length - 1; i > 0; i--)
            {
                if(parts[i]=="")
                { continue; }
                output += parts[i] + " ";
            }
            return output +parts[0];

        }
    }
}
