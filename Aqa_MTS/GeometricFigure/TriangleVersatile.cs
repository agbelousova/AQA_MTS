namespace GeometricFigure;

public class TriangleVersatile : Triangle
{
    public TriangleVersatile(float lengthA, float lengthB, float lengthC) : base(lengthA, lengthB, lengthC)
    {
    }

    public void Area(float LengthA, float LengthB, float LengthC)
    {
        //полупериметр треугольника
        float pTriangle = (LengthA + LengthB + LengthC) / 2;
        S = Convert.ToSingle(
            Math.Sqrt(pTriangle
                      * (pTriangle - LengthA)
                      * (pTriangle - LengthB)
                      * (pTriangle - LengthC)));
        Console.WriteLine($"Площадь = {S}");
    }
}