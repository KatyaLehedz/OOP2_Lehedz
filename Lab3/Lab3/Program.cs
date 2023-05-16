using Lab3;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть a, b та c для рівняння ax^2 + bx + c = 0.");
        Console.Write("a:");
        double a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        double b = int.Parse(Console.ReadLine());
        Console.Write("c:");
        double c = int.Parse(Console.ReadLine());
        Solver solver = new Solver(a, b, c);

        while (true)
        {
            Console.WriteLine("\nКвадратне рівняння: {0}x^2 {3}{1}x {4}{2} = 0",
                a, b, c, (b >= 0 ? "+ " : ""), (c >= 0 ? "+ " : ""));

            Console.WriteLine();
            Console.WriteLine("1. Знайти розв'язок в просторі R.");
            Console.WriteLine("2. Знайти розв'язок в просторі комплексних чисел.");
            Console.WriteLine("3. Змінити дані для квадратного рівняння.");
            Console.WriteLine("0. Вихід.");

            Console.Write("Виберіть простір: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Розв'язок в просторі R.\n\n");

                    double[] realResult = ((EquationSolver)solver).SolveReal();

                    Console.WriteLine("Розв'язки квадратного рівняння: x1 = {0}, x2 = {1}", realResult[0], realResult[1]);
                    break;

                case 2:
                    Console.Write("Розв'язок в просторі R.\n\n");

                    Complex[] complexResult = ((ComplexEquationSolver)solver).SolveComplex();

                    Console.WriteLine("Розв'язки квадратного рівняння: x1 = {0}, x2 = {1}",
                        Solver.ToStringComplex(complexResult[0]),
                        Solver.ToStringComplex(complexResult[1]));
                    break;

                case 3:
                    Console.WriteLine("\nВведіть a, b та c для рівняння ax^2 + bx + c = 0.");
                    Console.Write("a:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b:");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("c:");
                    c = int.Parse(Console.ReadLine());
                    solver.ChangeData(a, b, c);
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