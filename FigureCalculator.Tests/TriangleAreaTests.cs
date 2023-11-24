using FigureCalculator.Lib;
using FigureCalculator.Lib.Intefaces;

namespace FigureCalculator.Tests;

public class TriangleAreaTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateArea_NotRightAngled()
    {
        // Arrange
        double sideA = 5;
        double sideB = 12;
        double sideC = 13;
        IFigure triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double expectedArea = 30; 
        double actualArea = triangle.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); 
    }

    [Test]
    public void CalculateArea_RightAngled()
    {
        // Arrange
        double sideA = 8;
        double sideB = 6;
        double sideC = 10;
        IFigure triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double expectedArea = 24; 
        double actualArea = triangle.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); 
    }
}