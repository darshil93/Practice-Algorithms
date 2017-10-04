using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string _myName = "Forget  CVs..Save time .  x x";
            int max = 0;
            var x = _myName.Split('.', '?', '!');
            foreach(var y in x)
            {
                int count = 0;
                //int count = y.Trim().Split(' ').Count();
                var z = y.Trim().Split(' ');
                foreach(var i in z) { if (i != "") { count++; } }
                max = Math.Max(max, count);
            }
            var LongestWord = _myName.Split(' ').OrderByDescending(r => r.Length).FirstOrDefault();
        }
    }
}
