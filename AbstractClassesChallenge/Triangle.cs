using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            int a, b, c;

            public Triangle(int a, int b, int c, string Name, int NumSides) : base(Name, NumSides)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public override void SetArea()
            {
                double triPerimeter = (a + b + c) / 2.0D;
                area = Math.Sqrt(triPerimeter * (triPerimeter - a) * (triPerimeter - b) * (triPerimeter - c) );
            }
    }
}
