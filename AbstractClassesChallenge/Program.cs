using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle myRect = new Rectangle(4, 8, "rectangle", 4);
            myRect.SetArea();
            myRect.GetInfo();

            Triangle myTri = new Triangle(4, 12, 15, "triangle", 3);
            myTri.SetArea();
            myTri.GetInfo();

            Square mySqu = new Square(5, 5, "square", 4);
            mySqu.SetArea();
            mySqu.GetInfo();


        }
    }
}
