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
            Console.WriteLine("Сериализация");
            Shape[] shape = CreatFigure.GetShapes();
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream((path + ".xml"), FileMode.Create))
            {
                serializer.Serialize(fs, shape);
            }
            Console.WriteLine("===================");
        }

        private static void XmlDeserializaFigur(string path)
        {
            Console.WriteLine("Десериализация");
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(path + ".xml", FileMode.Open))
            {
                Shape[] shapes = (Shape[])serializer.Deserialize(fs);
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine($"Фигура {shape.Name} и её объём {shape.ShapeVolume}");
                }
            }
            Console.WriteLine("===================");
        }

        private static async void  JsonSerializeFigur(string path)
        {
            Console.WriteLine("Сериализация");
            using (FileStream fs = new FileStream((path + ".json"), FileMode.Create))
            {
                Shape[] shapes = CreatFigure.GetShapes();
                await JsonSerializer.SerializeAsync<Shape[]>(fs, shapes);
                Console.WriteLine("Файл создан");
            }
            Console.WriteLine("===================");
        }

        private static async void JsonDeserializaFigur(string path)
        {
            Console.WriteLine("Десериализация");
            using (FileStream fs = new FileStream((path + ".json"), FileMode.Open))
            {
                Shape[] shapes = await JsonSerializer.DeserializeAsync<Shape[]>(fs);
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine($"Фигура {shape.Name} и её объём {shape.ShapeVolume}");
                }
                Console.WriteLine("===================");
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
            ////Encoding utf8 = Encoding.UTF8;
            //Console.WriteLine("Работа с файлами типа XML");
            //XmlSerializeFigur(path);
            //XmlDeserializaFigur(path);

            Console.WriteLine("Работа с файлами типа JSON");
            JsonSerializeFigur(path);
            Console.WriteLine("===================");
            JsonDeserializaFigur(path);

            Console.ReadKey();
        }
    }
}
