using System.Numerics;

namespace Lab3
{
    internal class Solver : EquationSolver, ComplexEquationSolver
    {
        private double a;
        private double b;
        private double c;

        public Solver(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ChangeData(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Discriminant()
        {
            return b * b - 4 * a * c;
        }

        public double[] SolveReal()
        {
            double discriminant = Discriminant();
            if (discriminant < 0)
            {
                Console.WriteLine("Дискримінант менше 0, рівняння не має розв'язків");
                return new double[] { 0, 0 };
            }
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return new double[] { x1, x2 };
        }

        public Complex[] SolveComplex()
        {
            double discriminant = Discriminant();
            Complex x1 = new Complex(-b / (2 * a), Math.Sqrt(-discriminant) / (2 * a));
            Complex x2 = new Complex(-b / (2 * a), -Math.Sqrt(-discriminant) / (2 * a));
            return new Complex[] { x1, x2 };
        }

        public static string ToStringComplex(Complex complex)
        {
            return complex.Real.ToString("0.00") + (complex.Imaginary >= 0 ? " + " : " ") + complex.Imaginary.ToString("0.00") + "i";
        }
    }

    public interface EquationSolver
    {
        double[] SolveReal();
    }

    public interface ComplexEquationSolver
    {
        Complex[] SolveComplex();
    }

}
