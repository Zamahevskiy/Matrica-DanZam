using System;

namespace Matrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(5, 5);
            Matrix matrix2 = new Matrix(4, 4);
            Matrix matrix3 = new Matrix(3, 3);
            Matrix matrix4 = new Matrix(2, 2);

            Console.WriteLine("Сумма первой и второй матрицы:");
            matrix1.Sum(matrix2);
            matrix1.Print();

            Console.WriteLine("Умножение:");
            matrix4.Multiply(7); 
            matrix4.Print();
            
            Console.WriteLine("Умножение матрицы на матрицу:");
            matrix2.MatrixMatrix(matrix3);
            matrix2.Print();
        }
    }
}
