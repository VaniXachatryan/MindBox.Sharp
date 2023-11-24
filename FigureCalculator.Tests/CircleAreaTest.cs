using FigureCalculator.Lib;
using FigureCalculator.Lib.Intefaces;

namespace FigureCalculator.Tests;

public class CircleAreaTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateArea()
    {
        // Arrange
        double radius = 3;
        IFigure circle = new Circle(radius);

        // Act
        double expectedArea = Math.PI * radius * radius;
        double actualArea = circle.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); 
    }
}