using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        protected int a, b;

        public Rectangle(string Name, int NumSides) : base(Name, NumSides)
        {
            this.a = 4;
            this.b = 6;
        }
        public Rectangle(int a, int b, string Name, int NumSides) : base(Name, NumSides)
        {
            this.a = 5;
            this.b = 5;
        }

        public override void SetArea()
        {
            area = a * b;
        }
        
    }
}
