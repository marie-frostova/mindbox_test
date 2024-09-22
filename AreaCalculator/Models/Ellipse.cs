namespace AreaCalculator.Models;

public class Ellipse : Figure
{
    public double MinorAxis { get; }
    public double MajorAxis { get; }

    public Ellipse(double minorAxis, double majorAxis)
    {
        if (minorAxis > 0 && majorAxis > 0)
        {
            MinorAxis = minorAxis;
            MajorAxis = majorAxis;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public override double CalculateArea()
    {
        return MinorAxis * MajorAxis * Math.PI;
    }
}