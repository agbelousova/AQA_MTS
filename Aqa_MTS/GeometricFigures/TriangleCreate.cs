namespace GeometricFigures;

public class TriangleCreate : Triangle
{
    public float LengthA { get; set; }
    public float LengthB { get; set; }
    public float LengthC { get; set; }
    
    public void FormTriangling(double lengthA, double lengthB, double lengthC) 
    {
        LengthA = this.LengthA;
        LengthB = this.LengthB;
        LengthC = this.LengthC;
            
        if (LengthA <= 0 || LengthB <= 0 || LengthC <= 0 || 
            LengthA + LengthB <= LengthC || LengthA + LengthC <= LengthB || 
            LengthC + LengthB <= LengthA) 
        {
            Console.WriteLine("Треугольника с такими сторонами не существует!!!");
            // return "нет";
        }
        if (LengthA == LengthB && LengthA == LengthC && LengthB == LengthC) 
        {
            Console.WriteLine("Треугольник равносторонний!");
            //return "равносторонний";
        }
        if (((LengthA * LengthA) == (LengthB * LengthB) + (LengthC * LengthC)) ||
            ((LengthB * LengthB) == ((LengthA * LengthA) + (LengthC * LengthC)) || 
             ((LengthC * LengthC) == (LengthB * LengthB) + (LengthA * LengthA)))) 
        {
            Console.WriteLine("Треугольник прямоугольный!");
            //    return "прямоугольный";
        }
        if ((LengthA == LengthB && LengthA != LengthC) || 
            (LengthB == LengthC && LengthB != LengthA) || 
            (LengthA == LengthC && LengthA != LengthB)) 
        {
            Console.WriteLine("Треугольник равнобедренный!");
            //    return "равнобедренный";
        }
        Console.WriteLine("Треугольник разносторонний!");
        // return "разносторонний";
    }

    public TriangleCreate(float lengthA, float lengthB, float lengthC) : base(lengthA, lengthB, lengthC)
    {
    }
}