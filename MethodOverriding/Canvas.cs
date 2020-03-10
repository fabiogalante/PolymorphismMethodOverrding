using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapres(List<Shape> shapes)
        {
            //Bad solution, add for each form
            //foreach (var shape in shapes)
            //{
            //    switch (shape.Type)
            //    {
            //        case ShapeType.Circle:
            //           Console.WriteLine("Draw a circle");
            //            break;

            //        case ShapeType.Rectangle:
            //            Console.WriteLine("Draw a rectangle");
            //            break;

            //        case ShapeType.Triangle:
            //            Console.WriteLine("Draw a triangle");
            //            break;
            //    }
            //}

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
