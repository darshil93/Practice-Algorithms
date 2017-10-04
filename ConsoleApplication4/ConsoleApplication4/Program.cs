using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static bool[ , ] dp;
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5,5 };
            int n = arr.Count();
            int sum = 10;
            printAllSubsets(arr, n, sum);
        }
        static void printAllSubsets(int[] arr, int n, int sum)
        {
            if (n == 0 || sum < 0)
                return;

            // Sum 0 can always be achieved with 0 elements
            dp = new bool[n , sum+1];
            for (int i = 0; i < n; ++i)
            {
                dp[i, 0] = true;
            }

            // Sum arr[0] can be achieved with single element
            if (arr[0] <= sum)
                dp[0 , arr[0]] = true;

            // Fill rest of the entries in dp[][]
            for (int i = 1; i < n; ++i)
                for (int j = 0; j < sum + 1; ++j)
                    dp[i , j] = (arr[i] <= j) ? (dp[i - 1, j] ||
                                               dp[i - 1, j - arr[i]])
                                             : dp[i - 1, j];
            if (dp[n - 1 , sum] == false)
            {
                Console.WriteLine("There are no subsets with" +
                                                      " sum " + sum);
                return;
            }

            // Now recursively traverse dp[][] to find all
            // paths from dp[n-1][sum]
            
            ArrayList p = new ArrayList();
            printSubsetsRec(arr, n - 1, sum, p);
        }
        static void display(ArrayList v)
        {
            foreach (var a in v)
            {
                Console.Write(a);
                
            }
            Console.ReadLine();
        }

        // A recursive function to print all subsets with the
        // help of dp[][]. Vector p[] stores current subset.
        static void printSubsetsRec(int[] arr, int i, int sum,  ArrayList p)
        {
            // If we reached end and sum is non-zero. We print
            // p[] only if arr[0] is equal to sun OR dp[0][sum]
            // is true.
            if (i == 0 && sum != 0 && dp[0, sum])
            {
                p.Add(arr[i]);
                display(p);
                p.Clear();
                return;
            }

            // If sum becomes 0
            if (i == 0 && sum == 0)
            {
                display(p);
                p.Clear();
                return;
            }

            // If given sum can be achieved after ignoring
            // current element.
            if (dp[i - 1 , sum])
            {
                // Create a new vector to store path
                ArrayList b = new ArrayList();
                b.AddRange(p);
                printSubsetsRec(arr, i - 1, sum, b);
            }

            // If given sum can be achieved after considering
            // current element.
            if (sum >= arr[i] && dp[i - 1 , sum - arr[i]])
            {
                p.Add(arr[i]);
                printSubsetsRec(arr, i - 1, sum - arr[i], p);
            }
        }

    }
}
