using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class MyMatrix
    {
        private int[,] matrix;

        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }

        public MyMatrix(int rowsCount, int columnsCount)
        {
            RowsCount = rowsCount;
            ColumnsCount = columnsCount;
            matrix = new int[RowsCount, ColumnsCount];
        }

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public void FillMatrixRandomly()
        {
            Random random = new Random();
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public MyMatrix GetDerivedMatrix(int order)
        {
            int derivedRowsCount = RowsCount - order + 1;
            int derivedColumnsCount = ColumnsCount - order + 1;
            MyMatrix derivedMatrix = new MyMatrix(derivedRowsCount, derivedColumnsCount);
            for (int i = 0; i < derivedRowsCount; i++)
            {
                for (int j = 0; j < derivedColumnsCount; j++)
                {
                    int sum = 0;
                    for (int k = i; k < i + order; k++)
                    {
                        for (int l = j; l < j + order; l++)
                        {
                            sum += matrix[k, l];
                        }
                    }
                    derivedMatrix.matrix[i, j] = sum;
                }
            }
            return derivedMatrix;
        }
    }
}
