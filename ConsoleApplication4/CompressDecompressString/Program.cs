using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompressDecompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compress("aaabbbaassvv"));
            Console.ReadLine();
            Console.WriteLine(Decompress(Compress("aaabbbaassvv")));
            Console.ReadLine();
        }
        public static string Compress(string s)
        {
            List<char> res = new List<char>();
            int count = 1;
            int i;
            for( i=0;i<s.Length-1;i++)
            {
                if(s[i]==s[i+1])
                {
                    count++;
                }
                else
                {
                    res.Add((char)s[i]);
                    res.Add(count.ToString().ToCharArray()[0]);
                    count = 1;
                }
            }
            res.Add((char)s[i]);
            res.Add(count.ToString().ToCharArray()[0]);
            count = 1;
            return new string(res.ToArray());
        }

        public static string Decompress(string s)
        {
            string res = "";
            int i;
            for(i=0;i<s.Length;i++)
            {
                if (char.IsLetter(s[i]))
                {
                    int k = int.Parse(s[i + 1].ToString());
                    for (int j = 0; j <k; j++)
                    { res += s[i];}
                    i++;
                }
               
            }


            return res;
        }
    }
}
