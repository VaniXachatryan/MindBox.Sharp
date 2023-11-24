// See https://aka.ms/new-console-template for more information

using FigureCalculator.Lib;
using FigureCalculator.Lib.Intefaces;

IFigure triangle = new Triangle(8.0, 6.0, 10.0);
Console.WriteLine($"Triangle: {triangle.CalculateArea()}");

IFigure triangle1 = new Triangle(5.0, 12.0, 13.0);
Console.WriteLine($"Triangle: {triangle1.CalculateArea()}");

IFigure circle = new Circle(10);
Console.WriteLine($"Circle: {circle.CalculateArea()}");