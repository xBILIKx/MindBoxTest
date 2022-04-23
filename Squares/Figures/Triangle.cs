using Squares.Interfaces;

namespace Squares.Figures;


public class Triangle : IFigure
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if ((firstSide + secondSide < thirdSide) || firstSide + thirdSide < secondSide ||
            secondSide + thirdSide < firstSide)
            throw new Exception("The triangle does not exist, check if you entered the correct values");
        
        
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        Square = CalculateSquare();
    }
    
    public double Square { get; }

    private double CalculateSquare()
    {
        double p = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Round(Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide)), 3);
    }

    public bool IsRight()
    {
        double aSq = Math.Pow(_firstSide, 2);
        double bSq = Math.Pow(_secondSide, 2);
        double cSq = Math.Pow(_thirdSide, 2);

        return (cSq.Equals(bSq + aSq)) || (bSq.Equals(aSq + cSq)) || (aSq.Equals(bSq + cSq));
    }
}