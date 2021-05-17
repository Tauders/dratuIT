using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using LibFigure;

namespace CreateFiles
{
    class Program
    {
        private static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("figures.json", FileMode.OpenOrCreate))
            {
                CreatFigure.GetShapes();
                Console.ReadKey();                
            }
        }
    }
}
