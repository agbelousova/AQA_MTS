//Создать отдельный класс который будет отвечать за логику создания
//треугольников. В нем вернуть нужный объект треугольника проверив его
//стороны
namespace GeometricFigure;

internal class TriangleCreate
{
    public static Triangle CreateTriangle(float lengthSideA, float lengthSideB, float lengthSideC)
    {
            if (lengthSideA == lengthSideB && lengthSideA == lengthSideC && lengthSideB == lengthSideC)
            {
                // Треугольник равносторонний
                return new TriangleEquilateral(lengthSideA);
            }

            if (((lengthSideA * lengthSideA) == (lengthSideB * lengthSideB) + (lengthSideC * lengthSideC)) ||
                ((lengthSideB * lengthSideB) == ((lengthSideA * lengthSideA) + (lengthSideC * lengthSideC)) ||
                 ((lengthSideC * lengthSideC) == (lengthSideB * lengthSideB) + (lengthSideA * lengthSideA))))
            {
                //Треугольник прямоугольный
                return new TriangleRightAngle(lengthSideA, lengthSideC, lengthSideB);
            }

            if ((lengthSideA == lengthSideB && lengthSideA != lengthSideC) ||
                (lengthSideB == lengthSideC && lengthSideB != lengthSideA) ||
                (lengthSideA == lengthSideC && lengthSideA != lengthSideB))
            {
                //Треугольник равнобедренный
                return new TriangleIsosceles(lengthSideC, lengthSideA);
            }


            // if ((lengthSideA + lengthSideB <= side_3) || (lengthSideA + side_3 <= lengthSideB) || (lengthSideB + side_3 <= lengthSideA))
            // {

            //  Треугольник разносторонний
            return new TriangleVersatile(lengthSideA, lengthSideB, lengthSideC);
    }
}