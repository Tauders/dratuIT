using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace CreateFiles
{
    class Program
    {
        private static Figures SelectFigure()
        {
            Random rdn = new Random();
            Figures figures = (Figures)rdn.Next(1,7);
            return figures;
        }

        private static Figures CreateFigure(Figures figures)
        {
            Random rdnSize = new Random();
            double h = rdnSize.NextDouble();
            double r = rdnSize.NextDouble();
            double s = rdnSize.NextDouble();
            
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
            return figures;
        }

        private static void FiguresArray()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 11);

            Figures[] figuresArrive = new Figures[n];
            for (int i = 0; i < figuresArrive.Length; i++)
            {
                figuresArrive[i] = CreateFigure(SelectFigure());
            }
        }

        private static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("figures.json", FileMode.OpenOrCreate))
            {
                FiguresArray();
                Console.ReadKey();                
            }
        }
    }
}
