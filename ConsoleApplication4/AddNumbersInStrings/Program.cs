using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbersInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings("12", "13"));
            Console.WriteLine(ProductStrings("12", "13"));
            Console.ReadLine();

        }
        public static string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0 || carry == 1; i--, j--)
            {
                int x = i < 0 ? 0 : num1[i] - '0';
                int y = j < 0 ? 0 : num2[j] - '0';
                sb.Append((x + y + carry) % 10);
                carry = (x + y + carry) / 10;
            }
            string res = sb.ToString();
            return new string(res.ToCharArray().Reverse().ToArray());

        }
        public static string ProductStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            
            for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0 || carry >= 1; i--, j--)
            {
                int x = i < 0 ? 0 : num1[i] - '0';
                int y = j < 0 ? 0 : num2[j] - '0';
                sb.Append((x * y + carry) % 10);
                carry = (x * y + carry) / 10;
            }
            string res = sb.ToString();
            return new string(res.ToCharArray().Reverse().ToArray());

        }
        public static string Multiply(string num1, string num2)
        {
            int m = num1.Length, n = num2.Length;
            int[] pos = new int[m + n];

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int p1 = i + j, p2 = i + j + 1;
                    int sum = mul + pos[p2];

                    pos[p1] += sum / 10;
                    pos[p2] = (sum) % 10;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (int p in pos) if (!(sb.Length == 0 && p == 0)) sb.Append(p);
            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}
