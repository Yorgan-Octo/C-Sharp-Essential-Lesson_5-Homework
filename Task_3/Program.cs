using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            MyMatrix matrix = new MyMatrix(10, 10);

            // заповнення матриці випадковими числами
            matrix.FillMatrixRandomly();

            Console.WriteLine("Матриця:");
            matrix.PrintMatrix();
            Console.WriteLine(new String('-', 50));

            matrix.RowsCount = 5;
            matrix.ColumnsCount = 5;

            Console.WriteLine("Матриця v2:");
            matrix.PrintMatrix();
            Console.WriteLine(new String('-', 50));

            Console.WriteLine("Матриця порядку 2:");
            MyMatrix derivedMatrix1 = matrix.GetDerivedMatrix(2);
            derivedMatrix1.PrintMatrix();
            Console.WriteLine(new String('-', 50));

            Console.WriteLine("Матриця порядку 3:");
            MyMatrix derivedMatrix2 = matrix.GetDerivedMatrix(3);
            derivedMatrix2.PrintMatrix();
            Console.ReadKey();

        }
    }
}
