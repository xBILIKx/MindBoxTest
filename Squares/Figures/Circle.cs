using Squares.Interfaces;

namespace Squares.Figures;


public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new Exception("Circle does not exist, check if the radius is correct");
        
        _radius = radius;
        Square = CalculateSquare();
    }
    
    public double Square { get; }
    
    private double CalculateSquare()
    {
        return Math.Round(Math.Pow(_radius, 2) * Math.PI, 3);
    }
}