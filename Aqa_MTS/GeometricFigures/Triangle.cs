namespace GeometricFigures;

internal class Triangle : GeometricFigure
{
    public Triangle()
    {
    }
    
    public double LenghtA;
    public double LenghtB;
    public double LenghtC;
    
    public Triangle(double lenghtA) : this()
    {
        if (lenghtA > 0) LenghtA = lenghtA;
    }
    
    public Triangle(double lenghtA, double lenghtB) : this(lenghtA)
    {
        if (lenghtB > 0) LenghtB = lenghtB;
    }
    public Triangle(double lenghtA, double lenghtB, double lenghtC) : this(lenghtA, lenghtB)
    {
        if (lenghtC > 0 && lenghtA < lenghtC + lenghtB && lenghtB < lenghtA + lenghtC && lenghtC < lenghtB + lenghtA)
        {
            LenghtC = lenghtC;
        }
    }

    public override double GetPerimetr()
    {
       return LenghtA + LenghtB + LenghtC;
    }

    public override double GetArea()
    {
        double pPerimetr = GetPerimetr() / 2;
        double area = Math.Sqrt(pPerimetr * (pPerimetr - LenghtA) * (pPerimetr - LenghtB) * (pPerimetr - LenghtC));
        return area;
    }
}