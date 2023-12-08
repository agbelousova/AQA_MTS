namespace GeometricFigure;

// Треугольник равносторонний
internal class TriangleEquilateral : Triangle
{
    public float LengthSide { get; set; }

    public TriangleEquilateral(float lengthSide)
    {
        LengthSide = lengthSide;
        TriangleType = "Равносторонний треугольник";
    }

    public override float Area()
    {
        return (float)(Math.Sqrt(3) / 4 * LengthSide * LengthSide);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Стороны: {LengthSide}, {LengthSide}, {LengthSide}\n");
    }
}