using AreaCalculator.Models;

namespace AreaCalculator;

public static class FigureCreator
{
    public static Triangle CreateTriangle(Point p1, Point p2, Point p3)
    {
        return new Triangle(p1, p2, p3);
    }
    
    public static Polygon CreatePolygon(Point[] vertices)
    {
        return new Polygon(vertices);
    }
    
    public static Circle CreateCircle(double radius)
    {
        return new Circle(radius);
    }
    
    public static Ellipse CreateEllipse(double minorAxis, double majorAxis)
    {
        return new Ellipse(minorAxis, majorAxis);
    }
}