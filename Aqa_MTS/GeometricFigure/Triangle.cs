namespace GeometricFigure;
abstract class Triangle : GeometricFigures
{
    protected string TriangleType { get; set; } = "Не определен";

    protected Triangle() => TypeGeometricFigure = "Треугольник";

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Вид треугольника - {TriangleType} \nПлощадь: {Area()}");
    }
}