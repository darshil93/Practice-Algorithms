﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            CountPrimes(5);
        }
        public static void CountPrimes(int n)
        {
            bool[] notPrime = new bool[n];
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (notPrime[i] == false)
                {
                    count++;
                    for (int j = 2; i * j < n; j++)
                    {
                        notPrime[i * j] = true;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
