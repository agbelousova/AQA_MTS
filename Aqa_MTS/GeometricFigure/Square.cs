namespace GeometricFigure;

//класс для подсчета площади квадрата
internal class Square : Quadrilateral
{
    public float LengthSide { get; set; }

    public Square(float lengthSide)
    {
        LengthSide = lengthSide;
        QuadrilateralType = "Квадрат";
    }

    public override float Area() => LengthSide * LengthSide;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Стороны квадрата: {LengthSide}\n");
    }
}