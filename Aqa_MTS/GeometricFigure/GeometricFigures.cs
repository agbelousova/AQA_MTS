namespace GeometricFigure;

//класс для реализации иерархии фигур
internal abstract class GeometricFigures
{
    protected string TypeGeometricFigure { get; set; } = "Не определен";
    public abstract float Area();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Тип геометрической фигуры: {TypeGeometricFigure}");
    }
}