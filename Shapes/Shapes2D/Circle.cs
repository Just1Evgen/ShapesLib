namespace Shapes.Shapes2D;

/// <summary>
/// Класс, представляющий круг.
/// </summary>
public class Circle : IShape2D
{
    public decimal Radius { get; }

    /// <summary>
    /// Площадь круга.
    /// </summary>
    public decimal Area => (decimal)Math.PI * Radius * Radius;

    public Circle(decimal radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive", nameof(radius));
        }

        Radius = radius;
    }
}