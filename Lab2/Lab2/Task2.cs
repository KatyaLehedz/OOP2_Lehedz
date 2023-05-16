namespace Lab2
{
    internal class Task2
    {
        Random random = new Random();
        public int[,] matrix;
        public int[] row;

        public int[,] Task_2_1(int n, int min, int max)
        {
            matrix = new int[n, n];
            row = new int[n];

            Console.WriteLine("Матриця: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(min, max);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 1) row[j] = matrix[i, j];
                }
                if (i % 2 == 1)
                {
                    Array.Sort(row);
                    Array.Reverse(row);
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = row[j];
                    }
                }
            }

            return matrix;
        }
        public void Task_2_2(int n, int min, int max)
        {
            matrix = new int[n, n];

            Console.WriteLine("Матриця: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(min, max);
                    Console.Write($"{matrix[i, j]} ");
                }
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                    if (matrix[i, j] < 0)
                    {
                        sum = 0;
                        break;
                    }
                    else if (j == n - 1) Console.Write($"Сума - {sum}");
                }
                Console.WriteLine();
            }
        }
        public int Task_2_3(int n, int min, int max)
        {
            matrix = new int[n, n];
            int result = int.MaxValue;

            Console.WriteLine("Матриця: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(min, max);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 2 - n; i < n - 1; i++)
            {
                if (i == 0) continue;
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    int k = j + i;
                    if (k >= 0 && k < n)
                    {
                        sum += Math.Abs(matrix[k, n - j - 1]);
                    }
                }
                if (sum < result)
                {
                    result = sum;
                }
            }

            return result;
        }
    }
}
