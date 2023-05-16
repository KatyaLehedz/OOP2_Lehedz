using Lab4;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        String input = File.ReadAllText(@"c:\matrix1.txt");
        int i = 0, j = 0;
        int[,] matrix1 = new int[3, 2];
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            foreach (var col in row.Trim().Split(' '))
            {
                matrix1[i, j] = int.Parse(col.Trim());
                j++;
            }
            i++;
        }

        input = File.ReadAllText(@"c:\matrix2.txt");
        i = 0;
        j = 0;
        int[,] matrix2 = new int[2, 4];
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            foreach (var col in row.Trim().Split(' '))
            {
                matrix2[i, j] = int.Parse(col.Trim());
                j++;
            }
            i++;
        }

        ArraySolver arrprog = new ArraySolver();
        ListSolver listprog = new ListSolver();

        Console.WriteLine("Матриця 1: ");
        arrprog.PrintMatrix(matrix1);

        Console.WriteLine("Матриця 2: ");
        arrprog.PrintMatrix(matrix2);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("\n1. За допомогою масивів.");
            Console.WriteLine("2. За допомогою колекцій List.");
            Console.WriteLine("0. Вихід.");

            Console.Write("Виберіть спосіб: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    int[,] resultMx = arrprog.MultiplyMatrices(matrix1, matrix2);
                    Console.WriteLine("\nРезультуюча матриця: ");
                    arrprog.PrintMatrix(resultMx);
                    break;

                case 2:
                    LinkedList<LinkedList<int>> listResultMx = listprog.MultiplyMatrices(matrix1, matrix2);
                    Console.WriteLine("\nРезультуюча матриця: ");
                    listprog.PrintMatrix(listResultMx);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Нема такого варіанту");
                    break;
            }
        }
    }
}