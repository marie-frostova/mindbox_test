namespace AreaCalculator.Models;

public sealed class Circle : Ellipse
{
    public double Radius { get; }
    public double Diameter => 2 * Radius;

    public Circle(double radius) : base(radius, radius)
    {
        if (radius > 0)
        {
            Radius = radius;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}