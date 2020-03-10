using System;

namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        //public ShapeType Type { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Draw base");
        }
    }


    //Polymorphism
    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a circle");
        }
    }


    //Polymorphism
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a Rectangle");
        }
    }
}
