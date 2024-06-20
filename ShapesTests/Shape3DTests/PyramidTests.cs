using Shapes.Shapes3D;

namespace ShapesTests.Shape3DTests;

public class PyramidTests
{
    [Theory]
    [InlineData(4, 6, 5, 19.87)]
    [InlineData(8, 12, 10, 71.50)]
    public void AreaCalculation(decimal baseArea, decimal basePerimeter, decimal height, decimal expectedArea)
    {
        var pyramid = new Pyramid(baseArea, basePerimeter, height);

        var area = pyramid.Area;

        Assert.Equal(expectedArea, area, 2);
    }

    [Theory]
    [InlineData(0, 6, 5)]
    [InlineData(4, 0, 5)]
    [InlineData(4, 6, 0)]
    public void InvalidPyramidDimensionsShouldThrowArgumentException(decimal baseArea, decimal basePerimeter, decimal height)
    {
        Assert.Throws<ArgumentException>(() => new Pyramid(baseArea, basePerimeter, height));
    }

    [Fact]
    public void NegativeBaseDimensionsShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Pyramid(-4, 6, 5));
    }
}