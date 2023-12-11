namespace GeometricFigures;

internal class Rectangle : Triangle
{
    public double RectangleLenghtA { get; set; }
    public double RectangleLenghtB { get; set; }
    
    public Rectangle () {}
    public Rectangle(double lenghtA) : base(lenghtA)
    {
      //  if (lenghtA > 0) LenghtA = lenghtA;
    }
    
    public Rectangle(double lenghtA, double lenghtB) : base(lenghtA, lenghtB)
    {
        RectangleLenghtA = lenghtA;
        RectangleLenghtB = lenghtB;

        //  if (lenghtB > 0) LenghtB = lenghtB;
    }

    public override double GetArea() => RectangleLenghtA * RectangleLenghtB;

    public override double GetPerimetr() => (RectangleLenghtA + RectangleLenghtB) * 2;

}