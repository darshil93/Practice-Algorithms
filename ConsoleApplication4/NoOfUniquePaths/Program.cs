using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfUniquePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            MinPathSum(3, 4);
        }
        public static int MinPathSum(int m, int n)
        {
            int[,] grid = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j != 0)
                    {
                        grid[i, j] = 1;
                    }
                    else if (i != 0 && j == 0)
                    {
                        grid[i, j] = 1;
                    }
                    else if (i == 0 && j == 0)
                    {
                        grid[i, j] = 0;
                    }
                    else
                    {
                        grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
                    }
                }
            }

            return grid[m - 1, n - 1];
        }
    }
}
