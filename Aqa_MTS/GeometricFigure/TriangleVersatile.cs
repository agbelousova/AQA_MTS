namespace GeometricFigure;

//Треугольник разносторонний
internal class TriangleVersatile : Triangle
{
    public float LengthA { get; set; }
    public float LengthB { get; set; }
    public float LengthC { get; set; }

    public TriangleVersatile(float lengthSideA, float lengthSideB, float lengthSideC)
    {
        LengthA = lengthSideA;
        LengthB = lengthSideB;
        LengthC = lengthSideC;
        TriangleType = "Разносторонний треугольник";
    }

    public override float Area()
    {
        float perimeterHalf = (LengthA + LengthB + LengthC) / 2;

        return Convert.ToSingle(
            Math.Sqrt(perimeterHalf
                      * (perimeterHalf - LengthA)
                      * (perimeterHalf - LengthB)
                      * (perimeterHalf - LengthC)));
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Стороны треугольника: {LengthA}, {LengthB}, {LengthC}\n");
    }
}