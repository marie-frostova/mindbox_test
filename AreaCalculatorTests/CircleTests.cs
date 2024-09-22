using AreaCalculator;
using AreaCalculator.Models;

namespace AreaCalculatorTests;

public class CircleTests
{
    private const double Eps = 0.001;
    
    [TestCase(-13)]
    [TestCase(-2)]
    [TestCase(0)]
    public void ThrowsArgumentExceptionWhenCantCreateCircle(double r)
    {
        Assert.Throws<ArgumentException>(() =>
            FigureCreator.CreateCircle(r));
    }
    
    [TestCase(9, 254.469)]
    [TestCase(16, 804.248)]
    [TestCase(1, 3.141)]
    public void CreatesCircleWhenRadiusIsPositiveAndCalculatesItsArea(double r, double expectedArea)
    {
        Circle? circle = null;
        try
        {
            circle = FigureCreator.CreateCircle(r);
        }
        catch (Exception)
        {
            //Ignored
        }
        Assert.That(circle is not null);

        var actualArea = circle!.CalculateArea();
        Assert.That(actualArea - expectedArea, Is.LessThan(Eps));
    }
}