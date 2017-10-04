using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "atp is good";
            s=new string(s.ToCharArray().Reverse().ToArray());
            string result = string.Join(" ",s.Split(' ').Select(x => new String(x.Reverse().ToArray())));

        }

    }
}
