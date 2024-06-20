namespace Shapes.Shapes2D;

/// <summary>
/// Интерфейс для двухмерных фигур.
/// </summary>
public interface IShape2D
{
    /// <summary>
    /// Площадь фигуры.
    /// </summary>
    decimal Area { get; }
}