using Squares.Interfaces;

namespace Squares;


public class Figure
{
    private readonly IFigure _figure;
    
    public Figure(IFigure figure)
    {
        _figure = figure;
    }
    
    public double Square => _figure.Square;
}