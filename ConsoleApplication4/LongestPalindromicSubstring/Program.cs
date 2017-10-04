using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// failed attempt to find Longest Palindromic Substring
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            string res= longestPalindrome(s);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static string longestPalindrome(string s)
        {
            int n = s.Length;
            string res = null;

            bool[,] dp = new bool[n,n];

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i; j < n; j++)
                {
                    dp[i,j] = s[i] == s[j] && (j - i < 3 || dp[i + 1,j - 1]);

                    if (dp[i,j] && (res == null || j - i + 1 > res.Length))
                    {
                        res = s.Substring(i, j + 1);
                    }
                }
            }

            return res;
        }
        //static string checkpalindrome(string s)
        //{
        //    string rev= new string(s.ToCharArray().Reverse().ToArray());
        //    int len = s.Length;
        //    if(rev==s && s.Length<=2)
        //    {
        //        return s;
        //    }
        //    else
        //    {
        //        int max = 0;
        //        string result = "";
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            for (int j =i+1; j<s.Length-i; j++)
        //            {
        //                if (findpalindrome(s.Substring(i, j)))
        //                {

        //                    if (s.Substring(i, j).Length > max)
        //                    {
        //                        result = s.Substring(i, j);
        //                        max = s.Substring(i, j).Length;
        //                    }
        //                }
        //            }
        //        }
        //        return result;
        //    }

        //}
        //static bool findpalindrome(string s)
        //{
        //    string rev = new string(s.ToCharArray().Reverse().ToArray());
        //    if (rev == s)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
