namespace GeometricFigures;

public class Triangle
{
        public float LengthA { get; set; }
        public float LengthB { get; set; }
        public float LengthC { get; set; }
         
        public Triangle(float lengthA, float lengthB, float lengthC)
        {
            LengthA = lengthA;
            LengthB = lengthB;
            LengthC = lengthC;
        }

        //площадь разностороннего треугольника считаем по формуле Герона 
        public virtual float TriangleVersatile ()
        {
            //полупериметр треугольника
            float pTriangle = (LengthA + LengthB + LengthC)/2;
            return Convert.ToSingle(
                        Math.Sqrt(pTriangle
                                  * (pTriangle - LengthA)
                                  * (pTriangle - LengthB)
                                  * (pTriangle - LengthC)));
        }
        
        //площадь равностороннего треугольника
        public float TriangleEquilateral ()
        {
            float side = LengthA; 
         
            return Convert.ToSingle((Math.Sqrt(3) * side * side)/4); 
        } 
        
        //площадь прямоугольного треугольникa
        public float TriangleRightAngled ()
        {
            return Convert.ToSingle(1/2*LengthA*LengthB);
        } 
        
        //площадь равнобедренного треугольникa
        public float TriangleIsosceles  ()
        {
            float h = Convert.ToSingle(Math.Sqrt(LengthB * LengthB - LengthA * LengthA / 4));
            return 1 / 2 * h * LengthB;
        }

        

        public void FormTriangling()
        {
          //  throw new NotImplementedException();
        }

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