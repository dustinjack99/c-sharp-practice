using System;
using System.Collections.Generic;
using System.Text;

namespace More_Practice
{
    class GeometryTool
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 3 };
            var triangle = new Triangle() { Base = 3, Height = 4 };

            square.Display();
            triangle.Display();
        }

    }


    //abstract class is a nice in-between of interfaces and classes
    abstract class Shape {
        public abstract int GetArea();

        public void Display()
        {
            Console.WriteLine(GetArea());
        }
       
}
    class Square : Shape
    {
        public int Width;

        public override int GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        public override int GetArea()
        {
            return Base * Height;
        }
    }
}
