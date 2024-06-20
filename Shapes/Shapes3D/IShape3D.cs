using Shapes.Shapes2D;

namespace Shapes.Shapes3D;

/// <summary>
/// Интерфейс для трехмерных фигур.
/// </summary>
public interface IShape3D : IShape2D
{
    /// <summary>
    /// Объем фигуры.
    /// </summary>
    decimal Volume { get; }
}