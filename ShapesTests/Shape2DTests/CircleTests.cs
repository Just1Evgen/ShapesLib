using Shapes.Shapes2D;

namespace ShapesTests.Shape2DTests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 3.14)]
    [InlineData(2, 12.57)]
    [InlineData(0.5, 0.79)]
    public void AreaCalculation(decimal radius, decimal expectedArea)
    {
        var circle = new Circle(radius);

        var area = circle.Area;

        Assert.Equal(expectedArea, area, 2);
    }

    [Fact]
    public void NegativeRadiusShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}
