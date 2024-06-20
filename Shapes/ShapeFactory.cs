namespace Shapes;

using Shapes2D;
using Shapes3D;

public static class ShapeFactory
{
    /// <summary>
    /// Создает экземпляр круга.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Экземпляр круга.</returns>
    public static IShape2D CreateCircle(decimal radius)
    {
        return new Circle(radius);
    }

    /// <summary>
    /// Создает экземпляр треугольника.
    /// </summary>
    /// <param name="sideA">Первая сторона треугольника.</param>
    /// <param name="sideB">Вторая сторона треугольника.</param>
    /// <param name="sideC">Третья сторона треугольника.</param>
    /// <returns>Экземпляр треугольника.</returns>
    public static IShape2D CreateTriangle(decimal sideA, decimal sideB, decimal sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }

    /// <summary>
    /// Создает экземпляр пирамиды.
    /// </summary>
    /// <param name="baseArea">Площадь основания пирамиды.</param>
    /// <param name="basePerimeter">Периметр основания пирамиды.</param>
    /// <param name="height">Высота пирамиды.</param>
    /// <returns>Экземпляр пирамиды.</returns>
    public static IShape3D CreatePyramid(decimal baseArea, decimal basePerimeter, decimal height)
    {
        return new Pyramid(baseArea, basePerimeter, height);
    }

    /// <summary>
    /// Создает экземпляр сферы.
    /// </summary>
    /// <param name="radius">Радиус сферы.</param>
    /// <returns>Экземпляр сферы.</returns>
    public static IShape3D CreateSphere(decimal radius)
    {
        return new Sphere(radius);
    }
}
