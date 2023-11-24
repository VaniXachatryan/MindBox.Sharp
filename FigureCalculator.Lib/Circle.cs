using FigureCalculator.Lib.Intefaces;

namespace FigureCalculator.Lib;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    
    public double CalculateArea()
        => Math.PI * _radius * _radius;
}