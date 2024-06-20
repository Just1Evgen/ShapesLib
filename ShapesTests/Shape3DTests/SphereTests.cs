using Shapes.Shapes3D;

namespace ShapesTests.Shape3DTests;

public class SphereTests
{
    [Theory]
    [InlineData(1, 12.57)]
    [InlineData(2, 50.27)]
    [InlineData(0.5, 3.14)]
    public void AreaCalculation(decimal radius, decimal expectedArea)
    {
        var sphere = new Sphere(radius);

        var area = sphere.Area;

        Assert.Equal(expectedArea, area, 2);
    }

    [Theory]
    [InlineData(1, 4.19)]
    [InlineData(2, 33.51)]
    [InlineData(0.5, 0.52)]
    public void VolumeCalculation(decimal radius, decimal expectedVolume)
    {
        var sphere = new Sphere(radius);

        var volume = sphere.Volume;

        Assert.Equal(expectedVolume, volume, 2);
    }

    [Fact]
    public void NegativeRadiusShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Sphere(-1));
    }
}