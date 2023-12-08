namespace GeometricFigure;
//Треугольник равнобедренный
internal class TriangleIsosceles : Triangle
    {
        public float LengthBase { get; set; }
        public float SideEqualOther { get; set; }

        public TriangleIsosceles(float lengthBase, float sideEqualOther)
        {
            LengthBase = lengthBase;
            SideEqualOther = sideEqualOther;
            TriangleType = "Равнобедренный треугольник";
        }

        public override float Area()
        {
            float triangleHeight = (float)Math.Sqrt(Math.Pow(SideEqualOther, 2)
                                                    - Math.Pow((float)LengthBase / 2, 2));

            return triangleHeight * LengthBase / 2;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Стороны: {LengthBase}, {SideEqualOther}, {SideEqualOther}\n");
        }
    }