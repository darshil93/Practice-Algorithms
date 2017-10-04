using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Rotate(new int[,] { {0,1,2}, {3,4,5}, {6,7,8} });
        }
        public static void Rotate(int[,] matrix)
        {
            int n = matrix.Length;
            n = Convert.ToInt16(Math.Sqrt(n));
            #region
            int[,] rev = new int[n,n];
            int k = n-1;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    rev[i, k] = matrix[i, j];
                }
                k--;
            }
#endregion
            //without using extra matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = 0;
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = 0;
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i,n - 1 - j];
                    matrix[i, n - 1 - j] = temp;
                }
            }
        }
    }
}
