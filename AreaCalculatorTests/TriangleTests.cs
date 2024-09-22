using AreaCalculator;
using AreaCalculator.Models;

namespace AreaCalculatorTests;

[TestFixture]
public class TriangleTests
{
    private const double Eps = 0.001;
    
    [TestCase(-13, -9, -2, -9, -1, -9)]
    [TestCase(20, 8, 18, -8, 15, -32)]
    [TestCase(-8, 10, 2, 10.2, 12, 10.4)]
    public void ThrowsArgumentExceptionWhenCantCreateTriangle(double px1, double py1, double px2, double py2, double px3, double py3)
    {
        Assert.Throws<ArgumentException>(() =>
            FigureCreator.CreateTriangle(new Point(px1, py1), new Point(px2, py2), new Point(px3, py3)));
    }
    
    [TestCase(-9, 4, 2, 4, 13, -10, 77)]
    [TestCase(-16.18, -7.78, -11, -6, -0.48, -3.46, 2.784)]
    [TestCase(-1, -2, -3, -9, -5, -6, 10)]
    public void CreatesTriangleWhenPointsAreNotOnOneLineAndCalculatesItsArea(double px1, double py1, double px2, double py2, double px3, double py3, double expectedArea)
    {
        Triangle? triangle = null;
        try
        {
            triangle = FigureCreator.CreateTriangle(new Point(px1, py1), new Point(px2, py2), new Point(px3, py3));
        }
        catch (Exception)
        {
            //Ignored
        }
        Assert.That(triangle is not null);

        var actualArea = triangle!.CalculateArea();
        Assert.That(actualArea - expectedArea, Is.LessThan(Eps));
    }
    
    [TestCase(-9, 4, 2, 4, 13, -10, false)]
    [TestCase(-16.18, -7.78, -11, -6, -0.48, -3.46, false)]
    [TestCase(-1, -2, -3, -9, -5, -6, false)]
    [TestCase(-10, 1, -9.5, 1, -9.5, 0.5, true)]
    [TestCase(-10, 0.2, -9.6, 0.4, -9.4, 0, true)]
    public void CreatesTriangleWhenPointsAreNotOnOneLineAndChecksItsRight(double px1, double py1, double px2, double py2, double px3, double py3, bool isRight)
    {
        Triangle? triangle = null;
        try
        {
            triangle = FigureCreator.CreateTriangle(new Point(px1, py1), new Point(px2, py2), new Point(px3, py3));
        }
        catch (Exception)
        {
            //Ignored
        }
        Assert.That(triangle is not null);

        var actual = triangle!.CheckIsRight();
        Assert.That(actual, Is.EqualTo(isRight));
    }
}