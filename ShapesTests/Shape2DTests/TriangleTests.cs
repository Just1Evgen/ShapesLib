using Shapes.Shapes2D;

namespace ShapesTests.Shape2DTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 8, 10, 24)]
    [InlineData(5, 5, 5, 10.83)]
    public void AreaCalculation(decimal sideA, decimal sideB, decimal sideC, decimal expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var area = triangle.Area;

        Assert.Equal(expectedArea, area, 2);
    }

    [Theory]
    [InlineData(1, 2, 3)] 
    [InlineData(0, 0, 0)]
    public void InvalidTriangleSidesShouldThrowArgumentException(decimal sideA, decimal sideB, decimal sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(8, 15, 17, true)]
    [InlineData(7, 24, 25, true)]
    [InlineData(3, 3, 3, false)]
    [InlineData(5, 5, 5, false)]
    public void IsRightTriangle_CorrectlyIdentifiesRightTriangles(decimal sideA, decimal sideB, decimal sideC, bool expected)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        Assert.Equal(expected, triangle.IsRightTriangle);
    }
}