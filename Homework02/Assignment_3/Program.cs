//assignment 4
//如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵 。给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。
using System;
namespace Assignment_4
{
    class Matrix
    {

        int[,] matrix;
        int m, n;
        public void setMatrix(int[,] array)
        {
            m = array.GetLength(0);//0维长度，即行数
            n = array.GetLength(1);//1维长度，即列数
            matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = array[i, j];
                }
            }
        }

        public bool IsToeplitz()
        {
            if (matrix.Length == 0) return true;
            for(int i = 1; i < m; i++)
            {
                for(int j=1;j< n; j++)
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1])
                        return false;
                }

            }

            return true;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Matrix b = new Matrix();
            int[,] array = { { 1, 2, 0, 4 }, { 0, 1, 2, 3 }, { 9, 0, 1, 2 } };
            b.setMatrix(array);
            Console.WriteLine(b.IsToeplitz());

        }
    }
}
