using FigureCalculator.Lib.Intefaces;

namespace FigureCalculator.Lib;

public class Triangle : IFigure
{
    private double _sideA, _sideB, _sideC;
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    
    public double CalculateArea()
    {
        if(IsRightAngled(_sideA, _sideB, _sideC))
            return (_sideA * _sideB) / 2;


        double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) *
                         (semiPerimeter - _sideC));
    }
    
    private bool IsRightAngled(double sideA, double sideB, double sideC)
    {
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}