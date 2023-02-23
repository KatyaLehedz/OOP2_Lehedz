using System;
using System.Drawing;

namespace oop2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TRTriangle triangle = null;
            bool isTriangle = false;
            int x = 0, y = 0;

            do
            {
                Console.Write("Menu.\n" +
                                  "1. Triangle.\n" +
                                  "2. Piramid.\n" +
                                  "3. Exit.\n" +
                                  "Enter your choose: ");
                int.TryParse(Console.ReadLine(), out int choose);

                switch (choose)
                {
                    case 1:
                        {
                            bool isWork = true;
                            do
                            {


                                Console.Write("Menu.\n" +
                                  "1. Create new triangle with default constructor.\n" +
                                  "2. Create new triangle with constructor with params.\n" +
                                  "3. Create new traignle with copy constructor.\n" +
                                  "4. Exit\n" +
                                  "Enter your choose: ");
                                int.TryParse(Console.ReadLine(), out choose);
                                Console.Clear();

                                switch (choose)
                                {
                                    case 1:
                                        {
                                            triangle = new TRTriangle();
                                            isTriangle = false;
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Write("Enter A X: ");
                                            int.TryParse(Console.ReadLine(), out x);
                                            Console.Write("Enter A Y: ");
                                            int.TryParse(Console.ReadLine(), out y);

                                            DPoint pointA = new DPoint(x, y);

                                            Console.Write("Enter B X: ");
                                            int.TryParse(Console.ReadLine(), out x);
                                            Console.Write("Enter B Y: ");
                                            int.TryParse(Console.ReadLine(), out y);

                                            DPoint pointB = new DPoint(x, y);

                                            isTriangle = true;
                                            Side sideAB = new Side(pointA, pointB);
                                            try
                                            {
                                                triangle = new TRTriangle(sideAB);
                                                triangle.Show();
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                                isTriangle = false;
                                            }
                                            finally
                                            {
                                                Console.WriteLine("Triangle was created!");
                                            }

                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Create triangle for copy!");
                                            Console.Write("Enter A X: ");
                                            int.TryParse(Console.ReadLine(), out x);
                                            Console.Write("Enter A Y: ");
                                            int.TryParse(Console.ReadLine(), out y);

                                            DPoint pointA = new DPoint(x, y);

                                            Console.Write("Enter B X: ");
                                            int.TryParse(Console.ReadLine(), out x);
                                            Console.Write("Enter B Y: ");
                                            int.TryParse(Console.ReadLine(), out y);

                                            DPoint pointB = new DPoint(x, y);

                                            Side sideAB = new Side(pointA, pointB);
                                            isTriangle = true;
                                            TRTriangle copyTriangle = null;
                                            try
                                            {
                                                copyTriangle = new TRTriangle(sideAB);
                                                triangle = new TRTriangle(copyTriangle);
                                                triangle.Show();
                                            }
                                            catch (Exception e)
                                            {
                                                isTriangle = false;
                                                Console.WriteLine(e.Message);
                                            }
                                            finally
                                            {
                                                Console.WriteLine("Triangle was created!");
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            isWork = false;
                                        }
                                        break;
                                }
                            } while (isWork);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine();

                            Console.Write("Enter A X: ");
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Enter A Y: ");
                            int.TryParse(Console.ReadLine(), out y);

                            DPoint pointA = new DPoint(x, y);

                            Console.Write("Enter B X: ");
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Enter B Y: ");
                            int.TryParse(Console.ReadLine(), out y);

                            DPoint pointB = new DPoint(x, y);



                            Side sideAB = new Side(pointA, pointB);

                            Console.Write("Enter H: ");
                            double.TryParse(Console.ReadLine(), out double h);

                            TPiramid piramid = null;
                            try
                            {
                                triangle = new TRTriangle(sideAB);
                                piramid = new TPiramid(triangle, h);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }
                            piramid.Show();
                        }
                        break;
                    case 3: return;
                }
            } while (true);
        }
    }



    public class DPoint
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public DPoint()
        {
            X = 0;
            Y = 0;
        }

        public DPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public DPoint(DPoint point)
        {
            X = point.X;
            Y = point.Y;
        }

        public override string ToString()
        {
            return $"[X: {X}. Y: {Y}.]";
        }

        public static implicit operator string(DPoint point)
        {
            return point.ToString();
        }



        public static DPoint operator +(DPoint fPoint, DPoint sPoint) =>
            new DPoint(fPoint.X + sPoint.X, fPoint.Y + sPoint.Y);

        public static DPoint operator -(DPoint fPoint, DPoint sPoint) =>
            new DPoint(fPoint.X - sPoint.X, fPoint.Y - sPoint.Y);

        public static DPoint operator *(DPoint point, int number) =>
            new DPoint(point.X * number, point.Y * number);

        public static bool operator ==(DPoint fPoint, DPoint sPoint)
            => fPoint.X == sPoint.X && fPoint.Y == sPoint.Y;

        public static bool operator !=(DPoint fPoint, DPoint sPoint)
            => fPoint.X != sPoint.X || fPoint.Y != sPoint.Y;
    }


    public class Side
    {
        public DPoint PointA { get; set; }
        public DPoint PointB { get; set; }

        public Side()
        {
            PointA = new DPoint();
            PointB = new DPoint();
        }

        public Side(DPoint pointA, DPoint pointB)
        {
            PointA = pointA;
            PointB = pointB;
        }

        public Side(Side side)
        {
            PointA = side.PointA;
            PointB = side.PointB;
        }

        public double GetDistance()
        {
            return Math.Round(Math.Sqrt(Math.Pow(PointA.X - PointB.X, 2) + Math.Pow(PointA.Y - PointB.Y, 2)), 2);
        }

        public override string ToString() => GetDistance().ToString();

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            return this == (Side)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static implicit operator double(Side side) => side.GetDistance();

        public static Side operator +(Side a, Side b) =>
            new Side(a.PointA + b.PointA, a.PointB + b.PointB);

        public static Side operator -(Side a, Side b) =>
            new Side(a.PointA - b.PointA, a.PointB - b.PointB);

        public static Side operator *(Side a, int number) =>
            new Side(a.PointA * number, a.PointB * number);


        public static bool operator ==(Side a, Side b)
            => a.PointA == b.PointA && a.PointB == b.PointB;

        public static bool operator !=(Side a, Side b)
            => a.PointA != b.PointA || a.PointB != b.PointB;

    }


    public class TRTriangle
    {
        public Side SideAB { get; set; }
        public Side SideBC { get; set; }
        public Side SideCA { get; set; }

        public TRTriangle()
        {
            SideAB = new Side();
            SideBC = new Side();
            SideCA = new Side();
        }
        public TRTriangle(Side sideAB)
        {
            SideAB = sideAB;
            SideBC = sideAB;
            SideCA = sideAB;
            if (IsDegenerateTriangle()) throw new Exception("Warning. Triangle is degenerate!");
        }

        public TRTriangle(TRTriangle square)
        {
            SideAB = new Side(square.SideAB);
            SideBC = new Side(square.SideBC);
            SideCA = new Side(square.SideCA);

            if (IsDegenerateTriangle()) throw new Exception("Warning. Triangle is degenerate!");
        }

        public double GetSquare()
        {
            double p = ((double)SideAB + (double)SideBC + (double)SideCA) / 2d;
            return Math.Sqrt(p * (p - SideAB) * (p - SideBC) * (p - SideCA));
        }


        public double GetPerimetr()
        {
            return (double)SideAB + (double)SideBC + (double)SideCA;
        }


        private bool IsDegenerateTriangle()
        {
            return (SideAB.GetDistance() == SideBC.GetDistance() + SideCA.GetDistance()) ||
                (SideBC.GetDistance() == SideAB.GetDistance() + SideCA.GetDistance()) ||
                (SideCA.GetDistance() == SideAB.GetDistance() + SideBC.GetDistance());
        }

        public static TRTriangle operator +(TRTriangle firstSquare, TRTriangle secondSquare)
        {
            return new TRTriangle(firstSquare.SideAB + secondSquare.SideAB);
        }

        public static TRTriangle operator -(TRTriangle firstSquare, TRTriangle secondSquare)
        {
            return new TRTriangle(firstSquare.SideAB - secondSquare.SideAB);
        }

        public static TRTriangle operator *(TRTriangle square, int number)
        {
            return new TRTriangle(square.SideAB * number);
        }

        public static bool operator ==(TRTriangle fSquare, TRTriangle sSquare) =>
            fSquare.SideAB == sSquare.SideAB &&
            fSquare.SideBC == sSquare.SideBC &&
            fSquare.SideCA == sSquare.SideCA;

        public static bool operator !=(TRTriangle fSquare, TRTriangle sSquare) =>
            fSquare.SideAB != sSquare.SideAB ||
            fSquare.SideBC != sSquare.SideBC ||
            fSquare.SideCA != sSquare.SideCA;

        public void Show()
        {
            Console.WriteLine($"Side AB: {SideAB}. Side BC: {SideBC}");
            Console.WriteLine($"Side CA: {SideCA}.");
            Console.WriteLine($"Square: {Math.Round(GetSquare(), 2)} / Perimetr: {Math.Round(GetPerimetr(), 2)}");
        }

    }


    public class TPiramid : TRTriangle
    {
        public double H { get; set; }
        public TPiramid() : base()
        {
            H = 0;
        }

        public TPiramid(TRTriangle square, double h) : base(square)
        {
            H = h;
        }

        public TPiramid(Side sideAB, double h) : base(sideAB)
        {
            H = h;
        }

        public double GetVolume() =>
            (H * Math.Pow(SideAB.GetDistance(), 2)) / (4 * Math.Sqrt(3));

        public void Show()
        {
            Console.WriteLine($"Side AB: {SideAB}. Side BC: {SideBC}");
            Console.WriteLine($"Side CA: {SideCA}. Volume: {Math.Round(GetVolume(), 2)}");
            Console.WriteLine($"Square: {Math.Round(GetSquare(), 2)} / Perimetr: {Math.Round(GetPerimetr(), 2)}");
        }
    }
}