namespace Shapes.Shapes3D;

/// <summary>
/// Класс, представляющий сферу.
/// </summary>
public class Sphere : IShape3D
{
    public decimal Radius { get; }

    public Sphere(decimal radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive", nameof(radius));
        }

        Radius = radius;
    }

    /// <summary>
    /// Площадь поверхности сферы.
    /// </summary>
    public decimal Area => 4m * (decimal)Math.PI * Radius * Radius;


    /// <summary>
    /// Объем сферы.
    /// </summary>
    public decimal Volume => (decimal)(4.0 / 3.0) * (decimal)Math.PI * (decimal)Math.Pow((double)Radius, 3);
}