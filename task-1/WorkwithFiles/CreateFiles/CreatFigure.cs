using System;
using LibFigure;
using System.Xml.Serialization;

namespace CreateFiles
{
    public static class CreatFigure
    {
        private static Figure SelectFigure()
        {
            Random randomFigureNumber = new Random();
            return (Figure)randomFigureNumber.Next(1, 7);
        }

        private static Shape CreateShape(Figure figure)
        {
            Random randomSize = new Random();
            double h = randomSize.NextDouble() * (10.0 - 9.0) + 11;
            double r = randomSize.NextDouble() * (10.0 - 9.0) + 11;
            double s = randomSize.NextDouble() * (10.0 - 9.0) + 11;
            Shape shape;

            switch (figure)
            {
                case Figure.Cube:

                    shape = new Cube(r);
                    shape.FigureName = shape.ToString();
                    break;
                case Figure.Cylinder:
                    shape = new Cylinder(h, r);
                    shape.FigureName = shape.ToString();
                    break;
                case Figure.Pyramid:
                    shape = new Pyramid(s, r);
                    shape.FigureName = shape.ToString();
                    break;
                case Figure.Ball:
                    shape = new Ball();
                    shape.FigureName = shape.ToString();
                    break;
                case Figure.Cone:
                    shape = new Cone(h, r);
                    shape.FigureName = shape.ToString();
                    break;
                case Figure.Prism:
                    shape = new Prism(h);
                    shape.FigureName = shape.ToString();
                    break;
                default:
                    throw new Exception("Тип фигуры не определён");
            }
            Console.WriteLine($"Созданная вами фигура это {shape} и её объем {shape.Volume()}");
            return shape;
        }

        public static Shape[] GetShapes()
        {
            Random randomArrayNumder = new Random();
            int n = randomArrayNumder.Next(1, 11);

            Shape[] shapes = new Shape[n];
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i] = CreateShape(SelectFigure());
            }
            return shapes;
        }
    }
}