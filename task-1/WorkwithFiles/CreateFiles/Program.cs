﻿using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace CreateFiles
{
    class Program
    {
        private static Figure SelectFigure()
        {
            Random rdnFigureNumber = new Random();
            return (Figure)rdnFigureNumber.Next(1,7);
        }

        private static Shape CreateShape(Figure figure)
        {
            Random rdnSize = new Random();
            double h = rdnSize.NextDouble();
            double r = rdnSize.NextDouble();
            double s = rdnSize.NextDouble();
            Shape shape;
            
            switch (figure)
            {
                case Figure.Cube:
                    shape = new Cube(r);
                    break;
                case Figure.Cylinder:
                    shape = new Cylinder(h, r);
                    break;
                case Figure.Pyramid:
                    shape = new Pyramid(s, r);
                    break;
                case Figure.Ball:
                    shape = new Ball(r);
                    break;
                case Figure.Cone:
                    shape = new Cone(h,r);
                    break;
                case Figure.Prism:
                    shape = new Prism(h);
                    break;
                default:
                    throw new Exception("Тип фигуры не определён");
            }
            Console.WriteLine($"Созданная вами фигура это {shape} и её объем {shape.Volume()}");
            return shape;
        }

        private static Shape[] GetShapes()
        {
            Random rndArrayNumder = new Random();
            int n = rndArrayNumder.Next(1, 11);

            Shape[] shapes = new Shape[n];
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i] = CreateShape(SelectFigure());
            }
            return shapes;
        }

        private static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("figures.json", FileMode.OpenOrCreate))
            {
                GetShapes();
                             
            }
        }
    }
}
