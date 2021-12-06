using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public Square(string Name, int NumSides) : base(Name, NumSides)
        {
            a = 4;
            b = 5;
        }

        public Square(int a, int b, string Name, int NumSides) : base(a, b, Name, NumSides)
        {
            this.a = a;
            this.b = b;
            this.Name = Name;
            this.NumSides = NumSides;
        }
    }
}
