namespace Lab2
{
    internal class Task1
    {
        Random random = new Random();
        public int[] x, y;

        public int Task_1_1(int n, int min, int max)
        {
            x = new int[n];
            int result = int.MinValue;

            Console.Write("Масив: ");
            for (int i = 0; i < n; i++)
            {
                x[i] = random.Next(min, max);
                Console.Write($"{x[i]} ");

                if (x[i] < 0 && x[i] > result) result = x[i];
            }
            return result;
        }
        public double Task_1_2(int n)
        {
            x = new int[n];
            y = new int[n];

            Console.WriteLine("Введіть координати вектора x:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x[{i}]: ");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введіть координати вектора y:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"y[{i}]: ");
                y[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nВектор 1: [ ");
            foreach (int k in x) Console.Write($"{k} ");
            Console.Write("]\n");
            Console.Write("\nВектор 2: [ ");
            foreach (int k in y) Console.Write($"{k} ");
            Console.Write("]\n");

            double dotProduct = 0;
            double normX = 0;
            double normY = 0;

            for (int i = 0; i < n; i++)
            {
                dotProduct += x[i] * y[i];
                normX += x[i] * x[i];
                normY += y[i] * y[i];
            }

            double cosAngle = dotProduct / (Math.Sqrt(normX) * Math.Sqrt(normY));

            return cosAngle;
        }
        public int[] Task_1_3(int n, int min, int max)
        {
            x = new int[n];
            y = new int[n];
            int count = 0;

            Console.Write("Масив: ");
            for (int i = 0; i < n; i++)
            {
                x[i] = random.Next(min, max);
                Console.Write($"{x[i]} ");
            }

            Console.Write("\nВведіть a інтервалу [a,b]: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Введіть b інтервалу [a,b]: ");
            max = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(x[i]) >= min && Math.Abs(x[i]) <= max) count++;
                else y[i - count] = x[i];
            }
            for (int i = count; i < n; i++) y[i] = 0;

            return y;
        }
    }
}
