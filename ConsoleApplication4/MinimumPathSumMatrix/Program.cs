using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumPathSumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MinPathSum(new int[,] { { 1, 1, 1 }, { 1, 2, 3 }, { 1, 1, 1 } });
        }
        public static int MinPathSum(int[,] grid)
        {
            int m = grid.GetLength(0);// row
            int n = grid.GetLength(1); // column
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j != 0)
                    {
                        grid[i, j] = grid[i, j] + grid[i, j - 1];
                    }
                    else if (i != 0 && j == 0)
                    {
                        grid[i, j] = grid[i, j] + grid[i - 1, j];
                    }
                    else if (i == 0 && j == 0)
                    {
                        grid[i, j] = grid[i, j];
                    }
                    else
                    {
                        grid[i, j] = Math.Min(grid[i, j - 1], grid[i - 1, j]) + grid[i, j];
                    }
                }
            }

            return grid[m - 1, n - 1];
        }
    }
}
