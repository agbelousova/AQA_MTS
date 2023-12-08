namespace GeometricFigure;
internal class Rectangle : Quadrilateral
    {
        public float LengthA { get; set; }
        public float LengthB { get; set; }

        public Rectangle(float lengthSideA, float lengthSideB)
        {
            LengthA = lengthSideA;
            LengthB = lengthSideB;
            QuadrilateralType = "Прямоугольник";
        }

        public override float Area() => LengthA * LengthB;

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Стороны прямоугольника: {LengthA}, {LengthB}\n");
        }
    }