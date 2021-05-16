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
            Random rdnFigureNumber = new Random();
            Figures figures = (Figures)rdnFigureNumber.Next(1,7);
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
                    Shape cube = new Cube(r);
                    Console.WriteLine($"Созданная вами фигура это {cube} и её объем {cube.Volume()}");
                    break;
                case Figures.Cylinder:
                    Shape cylinder = new Cylinder(h, r);
                    Console.WriteLine($"Созданная вами фигура это {cylinder} и её объем {cylinder.Volume()}");
                    break;
                case Figures.Pyramid:
                    Shape pyramid = new Pyramid(s, r);
                    Console.WriteLine($"Созданная вами фигура это {pyramid} и её объем {pyramid.Volume()}");
                    break;
                case Figures.Ball:
                    Shape ball = new Ball(r);
                    Console.WriteLine($"Созданная вами фигура это {ball} и её объем {ball.Volume()}");
                    break;
                case Figures.Cone:
                    Shape cone = new Cone(h,r);
                    Console.WriteLine($"Созданная вами фигура это {cone} и её объем {cone.Volume()}");
                    break;
                case Figures.Prism:
                    Shape prism = new Prism(h);
                    Console.WriteLine($"Созданная вами фигура это {prism} и её объем {prism.Volume()}");
                    break;
            }
            return figures;
        }

        private static void FiguresArray()
        {
            Random rndArrayNumder = new Random();
            int n = rndArrayNumder.Next(1, 11);

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
