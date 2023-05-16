using Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Task1 task1 = new Task1();
        Task2 task2 = new Task2();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Завдання 1.1");
            Console.WriteLine("2. Завдання 1.2");
            Console.WriteLine("3. Завдання 1.3");
            Console.WriteLine("4. Завдання 2.1");
            Console.WriteLine("5. Завдання 2.2");
            Console.WriteLine("6. Завдання 2.3");
            Console.WriteLine("0. Вихід");

            Console.Write("Виберіть завдання: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Дано n дійсних чисел: x1, x2,..., xn. Знайти найбільше серед від’ємних.\n\n");

                    Console.Write("Введіть кількість чисел: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("Введіть нижню межу для генерування чисел: ");
                    int min = int.Parse(Console.ReadLine());
                    Console.Write("Введіть верхню межу для генерування чисел: ");
                    int max = int.Parse(Console.ReadLine());

                    int result = task1.Task_1_1(n, min, max);
                    if (result == int.MinValue) Console.Write("\nВ масиві нема від'ємних чисел");
                    else Console.WriteLine($"\nНайбільше серед від’ємних чисел: {result}");
                    break;

                case 2:
                    Console.Write("Дано два вектори x, y є Rn. Знайти косинус кута між ними.\n\n");

                    Console.Write("Введіть розмірність векторів: ");
                    n = int.Parse(Console.ReadLine());

                    double resultAngle = task1.Task_1_2(n);
                    Console.WriteLine($"\nКосинус кута між векторами: {resultAngle}");
                    break;

                case 3:
                    Console.Write("Стиснути масив, вилучивши з нього всі елементи, модуль яких знаходиться в інтервалі [a,b], " +
                        "\nмісце яке звільнилось в кінці масиву заповнити нулями.\n\n");

                    Console.Write("Введіть кількість чисел: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введіть нижню межу для генерування чисел: ");
                    min = int.Parse(Console.ReadLine());
                    Console.Write("Введіть верхню межу для генерування чисел: ");
                    max = int.Parse(Console.ReadLine());

                    int[] resultArr = task1.Task_1_3(n, min, max);
                    Console.Write("\nМасив після стиснення: ");
                    foreach (int k in resultArr) Console.Write($"{k} ");
                    break;

                case 4:
                    Console.Write("Дана цілочислова квадратна матриця. Розмістити елементи парних рядків у порядку спадання.\n\n");

                    Console.Write("Введіть розмірність матриці: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введіть нижню межу для генерування чисел: ");
                    min = int.Parse(Console.ReadLine());
                    Console.Write("Введіть верхню межу для генерування чисел: ");
                    max = int.Parse(Console.ReadLine());

                    int[,] resultMx = task2.Task_2_1(n, min, max);
                    Console.WriteLine("\nРезультуюча матриця: ");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++) Console.Write($"{resultMx[i, j]} ");
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    Console.Write("Дана цілочислова квадратна матриця. Визначити суму елементів в тих стовпцях, " +
                        "які не містять від’ємних елементів\n\n");

                    Console.Write("Введіть розмірність матриці: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введіть нижню межу для генерування чисел: ");
                    min = int.Parse(Console.ReadLine());
                    Console.Write("Введіть верхню межу для генерування чисел: ");
                    max = int.Parse(Console.ReadLine());

                    task2.Task_2_2(n, min, max);
                    break;

                case 6:
                    Console.Write("Дана цілочислова квадратна матриця. Визначити мінімум серед сум модулів " +
                        "\nелементів діагоналей, паралельних побічній діагоналі матриці.\n\n");

                    Console.Write("Введіть розмірність матриці: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введіть нижню межу для генерування чисел: ");
                    min = int.Parse(Console.ReadLine());
                    Console.Write("Введіть верхню межу для генерування чисел: ");
                    max = int.Parse(Console.ReadLine());

                    result = task2.Task_2_3(n, min, max);
                    Console.WriteLine($"Мінімальна сума: {result}");
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