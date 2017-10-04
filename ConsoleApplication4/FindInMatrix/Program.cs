using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = SearchMatrix(new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } }, 5);
        }
        public static  bool SearchMatrix(int[,] matrix, int target)
        {
            int n = Convert.ToInt16(Math.Sqrt(matrix.Length));
            bool res = true;
            int m =n, i = 0, j = n - 1;
            while (i < m && j >= 0)
            {
                if (matrix[i,j] == target) return true;
                else if (matrix[i,j] < target) i++;
                else j--;
            }
            return false;
            
        }
    }
}
