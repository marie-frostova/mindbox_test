namespace AreaCalculator.Models;

public class Polygon : Figure
{
    public List<Point> Vertices { get; }
    
    public Polygon(params Point[] vertices)
    {
        if (vertices.Length < 3)
            throw new ArgumentException();
        
        Vertices = vertices.ToList();
    }
    
    public override double CalculateArea()
    {
        double res = 0;
        for (var i = 0; i < Vertices.Count; i++) {
            var p1 = i == 0 ? Vertices[i - 1] : Vertices.Last();
            var p2 = Vertices[i];
            res += (p1.X - p2.X) * (p1.Y + p2.Y);
        }
        return Math.Abs(res) / 2;
    }
}