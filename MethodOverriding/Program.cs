﻿using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            //shapes.Add(new Shape{Width = 100, Height = 100, Type = ShapeType.Circle});
            //shapes.Add(new Shape { Width = 100, Height = 25, Type = ShapeType.Triangle });
            //shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapres(shapes);

        }
    }
}
