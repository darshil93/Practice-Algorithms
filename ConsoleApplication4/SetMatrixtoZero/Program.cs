using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMatrixtoZero
{
    class Program
    {
        static void Main(string[] args)
        {
            setZeroes(new int[,] { { 1, 1,1,1 }, { 2, 2, 0,2 }, { 3, 3, 3,3 } });
        }
        public static void setZeroes(int[,] matrix)
        {
            bool fr = false, fc = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (i == 0) fr = true;
                        if (j == 0) fc = true;
                        matrix[0, j] = 0;
                        matrix[i, 0] = 0;
                    }
                }
            }
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            if (fr)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[0, j] = 0;
                }
            }
            if (fc)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, 0] = 0;
                }
            }
        }
    }
}
