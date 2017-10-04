using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// binary tree from array without rebalancing and list from list with  order
namespace Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<String>> one = new List<List<String>>();
            List<String> first = new List<string>();
            first.Add("1");
            first.Add("2");

            List<String> second = new List<string>();
            second.Add("3");
            second.Add("anything");
            second.Add("4");

            one.Add(first);
            one.Add(second);

            List<String> two = new List<string>();
            first.Add("1");
            first.Add("2");
            first.Add("3");
            first.Add("4");
            first.Add("5");

            List<string> listA = new List<string>();
            listA.Add("1"); listA.Add("2"); listA.Add("3"); listA.Add("4");
            List<string> listB = new List<string>();
            listB.Add("3"); listB.Add("4");

            foreach(string s in listB)
            {
                if(s==listA[i])
                {

                }
            }
        }
        public static bool ContainsSequence( List<string> outer,List<string> inner)
        {
            int count = 0;
            if (outer.Count < inner.Count)
                return false;
            else
            {
                for(int i=0; i<outer.Count;i++)
                {
                    if(outer[i]==inner[i])
                    {

                    }
                }
            }

        }
    }
}
