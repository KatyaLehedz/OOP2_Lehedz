namespace Lab4
{
    internal class ListSolver
    {
        public LinkedList<LinkedList<int>> MultiplyMatrices(int[,] arrMx1, int[,] arrMx2)
        {
            Random random = new Random();
            LinkedList<LinkedList<int>> matrix1 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> matrix2 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> result = new LinkedList<LinkedList<int>>();

            for (int i = 0; i < arrMx1.GetLength(0); i++)
            {
                matrix1.AddLast(new LinkedList<int>());

                for (int j = 0; j < arrMx1.GetLength(1); j++)
                {
                    matrix1.Last.Value.AddLast(arrMx1[i, j]);
                }
            }

            for (int i = 0; i < arrMx2.GetLength(0); i++)
            {
                matrix2.AddLast(new LinkedList<int>());

                for (int j = 0; j < arrMx2.GetLength(1); j++)
                {
                    matrix2.Last.Value.AddLast(arrMx2[i, j]);
                }
            }

            if (matrix1.First.Value.Count != matrix2.Count)
            {
                Console.WriteLine("Кількість стовпців першої матриці не співпадає з кількістю рядків другої матриці." +
                    "\nНатисніть будь яку клавішу для виходу");
                Console.ReadLine();
                Environment.Exit(0);
            }

            foreach (LinkedList<int> row1 in matrix1)
            {
                int column = 0;
                result.AddLast(new LinkedList<int>());
                foreach (int element2 in matrix2.First.Value)
                {
                    int sum = 0;
                    int index = 0;
                    foreach (int element1 in row1)
                    {
                        sum += element1 * matrix2.ElementAt(index).ElementAt(column);
                        index++;
                    }
                    result.Last.Value.AddLast(sum);
                    column++;
                }
            }

            return result;
        }

        public void PrintMatrix(LinkedList<LinkedList<int>> matrix)
        {
            foreach (LinkedList<int> row in matrix)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}