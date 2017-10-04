using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";

            Console.WriteLine(longestPalindrome(s));
            Console.ReadLine();
        }
        private static int lo, maxLen;

        public static String longestPalindrome(String s)
        {
            int len = s.Length;
            if (len < 2)
                return s;

            for (int i = 0; i < len - 1; i++)
            {
                extendPalindrome(s, i, i);  //assume odd length, try to extend Palindrome as possible
                extendPalindrome(s, i, i + 1); //assume even length.
            }
            return s.Substring(lo, lo + maxLen);
        }

        private static void extendPalindrome(String s, int j, int k)
        {
            while (j >= 0 && k < s.Length && s[j] == s[k])
            {
                j--;
                k++;
            }
            if (maxLen < k - j - 1)
            {
                lo = j + 1;
                maxLen = k - j - 1;
            }
        }
    }
}
