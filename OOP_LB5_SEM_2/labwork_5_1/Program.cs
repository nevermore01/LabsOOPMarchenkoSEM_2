using System;

namespace labwork_5_1
{
    class Program
    {
        static int rows, columns;
        static void Main(string[] args)
        {
            //основная матрица
            EnterValues();
            Matrix matrix = new Matrix(rows,columns);
            matrix.CreateMatrix();

            Console.WriteLine("Созданная матрица: "); 
            matrix.PrintMatrix();

            Console.WriteLine($"Детерминант матрицы: {matrix.CalculateDeterminant()}");

            Console.WriteLine("\nТранспонированная матрица:");
            matrix.CreateTransposeMatrix().PrintMatrix();

            Console.WriteLine("\nОбратная матрица:");
            matrix.CreateInverseMatrix().PrintMatrix();

            //матрица В
            EnterValues();
            Matrix matrix2 = new Matrix(rows, columns);
            matrix2.CreateMatrix();
            Console.WriteLine("Созданная матрица: ");
            matrix2.PrintMatrix();

            //умножение
            Console.WriteLine("\nРезультат умножения первой матрицы на вторую");
            matrix.MultiplyMatrix(matrix2).PrintMatrix();
        }
        public static void EnterValues()
        {
            do
            {
                Console.Write("Введите количество строк: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество колонок: ");
                columns = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (rows <= 0 || columns <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Введите значения больше 0\n");
                    Console.ResetColor();
                }
            }
            while (rows <= 0 || columns <= 0);
        }
    }
}
