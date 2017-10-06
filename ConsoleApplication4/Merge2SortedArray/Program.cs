using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge2SortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);
        }

        public static void Merge(int[] a, int n, int[] b, int m)
        {
            int i = 0; int j = 0; int k = 0;
            int[] c = new int[m + n];
            if (n > 0)
            {
                while (i < n && j < m)
                {
                    if (a[i] > b[j])
                    {
                        c[k] = b[j]; j++; k++;
                    }
                    else
                    {
                        c[k] = a[i]; i++; k++;
                    }

                }
            }
            while (j < m)
            {
                c[k] = b[j];
                k++; j++;
            }
            while (i < n) { c[k] = a[i]; k++; i++; }
            for (i = 0; i < k; i++) { a[i] = c[i]; }
        }
    }
}

