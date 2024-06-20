using Shapes.Shapes2D;

namespace Shapes.Shapes3D;

/// <summary>
/// Класс, представляющий пирамиду.
/// </summary>
public class Pyramid : IShape3D
{
    public decimal BaseArea { get; }
    public decimal Height { get; }
    public decimal BasePerimeter { get; }

    /// <summary>
    /// Площадь поверхности пирамиды.
    /// </summary>
    public decimal Area
    {
        get
        {
            double basePerimeterDouble = Convert.ToDouble(BasePerimeter);
            double sqrt3 = Math.Sqrt(3);
            double part1 = Math.Pow(basePerimeterDouble / (2 * sqrt3), 2);
            double part2 = Convert.ToDouble(Height) * Convert.ToDouble(Height);
            decimal slantHeight = (decimal)Math.Sqrt(part1 + part2);

            return BaseArea + BasePerimeter * slantHeight / 2;
        }
    }

    /// <summary>
    /// Объем пирамиды.
    /// </summary>
    public decimal Volume => (BaseArea * Height) / 3;

    public Pyramid(decimal baseArea, decimal basePerimeter, decimal height)
    {
        if (baseArea <= 0 || height <= 0 || basePerimeter <= 0)
        {
            throw new ArgumentException("Base area, base perimeter, and height must be positive");
        }

        BaseArea = baseArea;
        Height = height;
        BasePerimeter = basePerimeter;
    }
}