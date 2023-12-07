//using GeometricFigure;

namespace GeometricFigure;

public class TriangleCreate : Triangle

{
    private Triangle[] _triangles = new Triangle[5];
    private int _index = 0;
    


    //добавляю переданный треугольник в массив

    public TriangleCreate(float lengthA, float lengthB, float lengthC) : base(lengthA, lengthB, lengthC)
    {
        lengthA = this.LengthA;
        lengthB = this.LengthA;
        lengthC = this.LengthA;
    }
    /*public TriangleCreate() : base()
    {
    }*/

    public void AddTriangle(Triangle triangle)
    {
        _triangles[_index++] = triangle;
        FormTriangling();
    }

    /*public void AreaTriangle()
    {
        for (int i = 0; i < _index; i++)
        {
            _triangles[i].
            FormTriangling();
        }
    }*/

    public void FormTriangling()
    {
        for (int i = 0; i < _index; i++)
        {
            if (LengthA <= 0 || LengthB <= 0 || LengthC <= 0 
                || LengthA <= LengthB + LengthC || LengthB <= LengthA + LengthC || LengthC <= LengthB + LengthA)
            {
                Console.WriteLine("Треугольника с такими сторонами не существует!!!");
                break;
            }

            if (LengthA == LengthB && LengthA == LengthC && LengthB == LengthC)
            {
                //  Console.WriteLine("Треугольник равносторонний!");
                _triangles[i].TriangleEquilateral();
            }

            if (((LengthA * LengthA) == (LengthB * LengthB) + (LengthC * LengthC)) ||
                ((LengthB * LengthB) == ((LengthA * LengthA) + (LengthC * LengthC)) ||
                 ((LengthC * LengthC) == (LengthB * LengthB) + (LengthA * LengthA))))
            {
                //  Console.WriteLine("Треугольник прямоугольный!");
                _triangles[i].TriangleRightAngled();
            }

            if ((LengthA == LengthB && LengthA != LengthC) ||
                (LengthB == LengthC && LengthB != LengthA) ||
                (LengthA == LengthC && LengthA != LengthB))
            {
                //    Console.WriteLine("Треугольник равнобедренный!");
                _triangles[i].TriangleIsosceles();
            }


            //  Console.WriteLine("Треугольник разносторонний!");
            _triangles[i].TriangleVersatile();
        }
    }

    /*public TriangleCreate(float lengthA, float lengthB, float lengthC)
    {
        lengthA = this.LengthA;
        lengthB = this.LengthB;
        lengthC = this.LengthC;
    }*/
}

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

    /*
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
    */

    /*public TriangleCreate(float lengthA, float lengthB, float lengthC) : base(lengthA, lengthB, lengthC)
    {
    }*/
    