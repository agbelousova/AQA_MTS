namespace GeometricFigure;

//класс для опеределния вида четырехугольника
internal abstract class Quadrilateral : GeometricFigures
{
    protected string QuadrilateralType { get; set; } = "Не определен";

    protected Quadrilateral() => TypeGeometricFigure = "Четырехугольник";

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Вид: {QuadrilateralType} \nПлощадь: {Area()}");
    }
}