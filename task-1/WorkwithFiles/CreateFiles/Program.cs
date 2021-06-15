using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using LibShapes;
using System.Xml.Serialization;
using System.Text;

namespace CreateFiles
{
    class Program
    {
        private static string CreateDirectory(string directory, string fileName)
        {
            Directory.CreateDirectory(directory);
            string path = (directory + "/") + fileName;
            return path;
        }


        private static void XmlSerializeFigur(string path)
        {
            Shape[] shape = CreatFigure.GetShapes();
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, shape);
            }
        }

        private static void XmlDeserializaFigur(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                Shape[] shapes = (Shape[])serializer.Deserialize(fs);
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine($"Фигура {shape.Name} и её объём {shape.ShapeVolume},");
                }
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Укажите место создаваемой директории");
            string directory = Console.ReadLine();
            Console.WriteLine("Введите название файла");
            string fileName = Console.ReadLine();
            string path = CreateDirectory(directory, fileName);
            Console.Clear();
            //Encoding utf8 = Encoding.UTF8;
            XmlSerializeFigur(path);
            Console.WriteLine("===================");
            XmlDeserializaFigur(path);

            Console.ReadKey();
        }
    }
}
