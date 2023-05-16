namespace Lab4
{
    internal class ArraySolver
    {
        public int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Кількість стовпців першої матриці не співпадає з кількістю рядків другої матриці." +
                    "\nНатисніть будь яку клавішу для виходу");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}