using System;

namespace CreateFiles
{
    class Program
    {
        enum Figures
        {
            Cube,
            Cylinder,
            Pyramid,
            Ball,
            Cone,
            Prism
        } 

        static private Figures SelectFigure()
        {
            Random rdn = new Random();
            Figures figures = (Figures)rdn.Next(6);
            return figures;
        }

        static private object CreateFigure(Figures figures)
        {
            Random rdnSize = new Random();
            double h = 11.0 + rdnSize.NextDouble() * (11.0 - 1.0);
            double r = 11.0 + rdnSize.NextDouble() * (11.0 - 1.0);
            double s = 11.0 + rdnSize.NextDouble() * (11.0 - 1.0);

            switch (figures)
            {
                case Figures.Cube:
                    Cube cube = new Cube(r);
                    Console.WriteLine($"Созданная вами фигура это {cube} и её объем {cube.Volume()}");
                    break;
                case Figures.Cylinder:
                    Cylinder cylinder = new Cylinder(h, r);
                    Console.WriteLine($"Созданная вами фигура это {cylinder} и её объем {cylinder.Volume()}");
                    break;
                case Figures.Pyramid:
                    Pyramid pyramid = new Pyramid(s, r);
                    Console.WriteLine($"Созданная вами фигура это {pyramid} и её объем {pyramid.Volume()}");
                    break;
                case Figures.Ball:
                    Ball ball = new Ball(r);
                    Console.WriteLine($"Созданная вами фигура это {ball} и её объем {ball.Volume()}");
                    break;
                case Figures.Cone:
                    Cone cone = new Cone(h, r);
                    Console.WriteLine($"Созданная вами фигура это {cone} и её объем {cone.Volume()}");
                    break;
                case Figures.Prism:
                    Prism prism = new Prism(h);
                    Console.WriteLine($"Созданная вами фигура это {prism} и её объем {prism.Volume()}");
                    break;
            }
            Console.WriteLine(figures);
            return figures;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 11);

            object[] vars = new object[n];
            for (int i = 0; i < vars.Length; i++)
            {
                vars[i] = CreateFigure(SelectFigure());
            }
            Console.WriteLine(vars);
            Console.ReadKey();



            

        }
    }
}
