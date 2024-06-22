namespace Shapes.Shapes2D;

/// <summary>
/// Класс, представляющий треугольник.
/// </summary>
public class Triangle : IShape2D
{
    public decimal SideA { get; }
    public decimal SideB { get; }
    public decimal SideC { get; }

    /// <summary>
    /// Площадь треугольника.
    /// </summary>
    public decimal Area
    {
        get
        {
            decimal s = (SideA + SideB + SideC) / 2;

            return Math.Round((decimal)Math.Sqrt((double)(s * (s - SideA) * (s - SideB) * (s - SideC))), 2);
        }
    }

    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRightTriangle
    {
        get
        {
            decimal aSquared = SideA * SideA;
            decimal bSquared = SideB * SideB;
            decimal cSquared = SideC * SideC;

            return aSquared + bSquared == cSquared ||
                   aSquared + cSquared == bSquared ||
                   bSquared + cSquared == aSquared;
        }
    }

    public Triangle(decimal sideA, decimal sideB, decimal sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("All sides must be positive");
        }

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("The given sides do not form a valid triangle");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
}
