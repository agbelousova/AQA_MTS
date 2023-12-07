namespace GeometricFigure;

public  class Triangle
{
    public float LengthA { get; set; }
    public float LengthB { get; set; }
    public float LengthC { get; set; }
  //  public float LengthD { get; set; }
    public float S;

    public Triangle(float lengthA, float lengthB, float lengthC)
    {
        LengthA = lengthA;
        LengthB = lengthB;
        LengthC = lengthC;
    }

    /*protected Triangle()
    {
        
    }*/

    /*public Triangle(int i, int i1, int i2)
    {
    }*/




    //площадь разностороннего треугольника считаем по формуле Герона
    public void TriangleVersatile ()
    {
        //полупериметр треугольника
        float pTriangle = (LengthA + LengthB + LengthC)/2;
        S = Convert.ToSingle(
            Math.Sqrt(pTriangle
                      * (pTriangle - LengthA)
                      * (pTriangle - LengthB)
                      * (pTriangle - LengthC)));
        Console.WriteLine($"Площадь = {S}");
    }

    //площадь равностороннего треугольника
    public void TriangleEquilateral ()
    {
        float side = LengthA;

        S = Convert.ToSingle((Math.Sqrt(3) * side * side)/4);
        Console.WriteLine($"Площадь = {S}");
    }

    //площадь прямоугольного треугольникa
    public void TriangleRightAngled ()
    {
        S = Convert.ToSingle(1/2*LengthA*LengthB);
        Console.WriteLine($"Площадь = {S}");
    }

    //площадь равнобедренного треугольникa
    public void TriangleIsosceles  ()
    {
        float h = Convert.ToSingle(Math.Sqrt(LengthB * LengthB - LengthA * LengthA / 4));
        S = 1 / 2 * h * LengthB;
        Console.WriteLine($"Площадь = {S}");
    }

/*
public void Area (float lengthA, float lengthB, float lengthC)
    {
        //полупериметр треугольника
        float pTriangle = (LengthA + LengthB + LengthC)/2;
        S = Convert.ToSingle(
            Math.Sqrt(pTriangle
                      * (pTriangle - LengthA)
                      * (pTriangle - LengthB)
                      * (pTriangle - LengthC)));
        Console.WriteLine($"Площадь = {S}");
    }
}

internal class TransportElectric : Transport
{
    public TransportElectric() : base() => TransportType = "Электрический транспорт";

    public override string GetTransportInfo() => base.PrintTransportInfo("Электрический");
}*/
    // private Triangle _triangle = new Triangle();
    /*
    public float S;
    private static TriangleCreate forma = new TriangleCreate(LengthA,  LengthB,  LengthC);
    private int t = FormTriangling(LengthA,  LengthB,  LengthC);
    */
/*
public float S;

    public void TriangleArea(int t)
    {

        switch (t)
        {
            case 1:
                TriangleEquilateral(LengthA,  LengthB,  LengthC);
                break;
            case 2:
                TriangleRightAngled(lengthA,  lengthB,  lengthC);
                break;
            case 3:
                TriangleIsosceles(lengthA,  lengthB,  lengthC);
                break;
            case 4:
                TriangleVersatile( lengthA,  lengthB,  lengthC);
                break;
            default:
                Console.WriteLine("Площадь не вычислена");
                break;
        }
    }

        /*public Triangle(float lengthA, float lengthB, float lengthC)
        {
            LengthA = lengthA;
            LengthB = lengthB;
            LengthC = lengthC;
        }#1#

        //площадь разностороннего треугольника считаем по формуле Герона
        public void TriangleVersatile (float lengthA, float lengthB, float lengthC)
        {
            //полупериметр треугольника
            float pTriangle = (lengthA + lengthB + lengthC)/2;
            S = Convert.ToSingle(
                        Math.Sqrt(pTriangle
                                  * (pTriangle - lengthA)
                                  * (pTriangle - lengthB)
                                  * (pTriangle - lengthC)));
            Console.WriteLine($"Площадь = {S}");
        }

        //площадь равностороннего треугольника
        public void TriangleEquilateral (float lengthA, float lengthB, float lengthC)
        {
            float side = lengthA;

            S = Convert.ToSingle((Math.Sqrt(3) * side * side)/4);
            Console.WriteLine($"Площадь = {S}");
        }

        //площадь прямоугольного треугольникa
        public void TriangleRightAngled (float lengthA, float lengthB, float lengthC)
        {
            S = Convert.ToSingle(1/2*lengthA*lengthB);
            Console.WriteLine($"Площадь = {S}");
        }

        //площадь равнобедренного треугольникa
        public void TriangleIsosceles  (float lengthA, float lengthB, float lengthC)
        {
            float h = Convert.ToSingle(Math.Sqrt(lengthB * lengthB - lengthA * lengthA / 4));
            S = 1 / 2 * h * lengthB;
            Console.WriteLine($"Площадь = {S}");
        }
        */



    /*public void FormTriangling()
    {
      //  throw new NotImplementedException();
    }*/



    /*public virtual void Area(object lengthA, object lengthB, object lengthC)
    {
        Console.WriteLine("Triangle");
    }*/
}

    /*
    internal class TriangleTwoSidesEqual : Triangle
    {
        public TriangleTwoSidesEqual(float lengthSideA, float lengthSideB) : base(lengthSideA, lengthSideA, lengthSideB) { }

        public override float TriangleArea()
        {
            float triangleBase = LengthSideA;
            float triangleEqualSide = LengthSideB;

            if (LengthSideA == LengthSideB)
            {
                triangleBase = LengthSideC;
            }
            else if (LengthSideA == LengthSideC)
            {
                triangleBase = LengthSideB;
                triangleEqualSide = LengthSideA;
            }

            float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(triangleEqualSide, 2)
                                         - Math.Pow(Convert.ToSingle(triangleBase) / 2, 2)));
            return TriangleHeight * triangleBase / 2;
        }
    }

    internal class TriangleAllSidesEqual : TriangleTwoSidesEqual
    {
        public TriangleAllSidesEqual(float lengthSideA) : base(lengthSideA, lengthSideA)
        {
        }

        public override float TriangleArea()
        {
            float TriangleHeight = Convert.ToSingle(Math.Sqrt(Math.Pow(LengthSideA, 2)
                             - Math.Pow(Convert.ToSingle(LengthSideA) / 2, 2)));
            return TriangleHeight * LengthSideA / 2;
        }
    }
}
}*/