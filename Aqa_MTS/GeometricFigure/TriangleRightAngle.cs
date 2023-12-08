namespace GeometricFigure;

//Треугольник прямоугольный
internal class TriangleRightAngle : Triangle
{
    public float LengthLeg1 { get; set; }
    public float LengthLeg2 { get; set; }
    public float LengthHypotenuse { get; set; }

    public TriangleRightAngle(float lengthLeg1, float lengthLeg2, float lengthHypotenuse)
    {
        LengthLeg1 = lengthLeg1;
        LengthLeg2 = lengthLeg2;
        LengthHypotenuse = lengthHypotenuse;
        TriangleType = "Прямоугольный треугольник";
    }

    public override float Area()
    {
        return LengthLeg1 * LengthLeg2 / 2;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Стороны: {LengthLeg1}, {LengthLeg2}, {LengthHypotenuse}\n");
    }
}