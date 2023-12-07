namespace GeometricFigur;

public class TriangleCreate : GeometricFigures
{
    /*public TriangleCreate(int i, int i1, int i2)
    {
       // throw new NotImplementedException();
    }*/
    /*public float LengthA { get; set; }
    public float LengthB { get; set; }
    public float LengthC { get; set; }*/
 //   public TriangleCreate(double lengthA, double lengthB, double lengthC) { }

    /*protected TriangleCreate()
    {
       // throw new NotImplementedException();
    }*/

    public int FormTriangling(double lengthA, double lengthB, double lengthC) 
    {
        lengthA = this.LengthA;
        lengthB = this.LengthB;
        lengthC = this.LengthC;
            
        if (lengthA <= 0 || lengthB <= 0 || lengthC <= 0) 
        {
          //  Console.WriteLine("Треугольника с такими сторонами не существует!!!");
             return 0;
             
        } 
        if (lengthA == lengthB && lengthA == lengthC && lengthB == lengthC) 
        {
          //  Console.WriteLine("Треугольник равносторонний!");
            return 1;
        } 
        if (((lengthA * lengthA) == (lengthB * lengthB) + (lengthC * lengthC)) ||
            ((lengthB * lengthB) == ((lengthA * lengthA) + (lengthC * lengthC)) || 
             ((lengthC * lengthC) == (lengthB * lengthB) + (lengthA * lengthA)))) 
        {
          //  Console.WriteLine("Треугольник прямоугольный!");
                return 2;
        } 
        if ((lengthA == lengthB && lengthA != lengthC) || 
            (lengthB == lengthC && lengthB != lengthA) || 
            (lengthA == lengthC && lengthA != lengthB)) 
        {
        //    Console.WriteLine("Треугольник равнобедренный!");
                return 3;
        }
      //  Console.WriteLine("Треугольник разносторонний!");
            return 4;
    }

    /*public TriangleCreate(float lengthA, float lengthB, float lengthC) : base(lengthA, lengthB, lengthC)
    {
    }*/

}