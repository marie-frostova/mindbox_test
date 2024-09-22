namespace AreaCalculator.Models;

public sealed class Triangle : Polygon
{
    public Point P1;
    public Point P2;
    public Point P3;

    public double Side1;
    public double Side2;
    public double Side3;
    
    public Triangle(Point p1, Point p2, Point p3) : base(p1, p2, p3)
    {
        Side1 = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        Side2 = Math.Sqrt(Math.Pow(p3.X - p1.X, 2) + Math.Pow(p3.Y - p1.Y, 2));
        Side3 = Math.Sqrt(Math.Pow(p3.X - p2.X, 2) + Math.Pow(p3.Y - p2.Y, 2));

        if (Side1 + Side2 > Side3 && Side1 + Side3 > Side2 && Side2 + Side3 > Side1)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public override double CalculateArea()
    {
        var p = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }

    public bool CheckIsRight()
    {
        const double eps = 0.001;
        return Math.Abs(Side1 * Side1 + Side2 * Side2 - Side3 * Side3) < eps ||
               Math.Abs(Side1 * Side1 + Side3 * Side3 - Side2 * Side2) < eps ||
               Math.Abs(Side2 * Side2 + Side3 * Side3 - Side1 * Side1) < eps;
    }
}