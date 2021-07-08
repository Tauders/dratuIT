using System;
using System.IO;
using LibShapes;
using System.Xml.Serialization;
using Newtonsoft.Json;


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


        private static void XmlSerializeFigur(string path, Shape[] shapes)
        {
            Console.WriteLine("Сериализация");
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream((path + ".xml"), FileMode.Create))
            {
                serializer.Serialize(fs, shapes);
            }
            Console.WriteLine("================================");
        }

        private static void XmlDeserializaFigur(string path, Shape[] shapes)
        {
            Console.WriteLine("Десериализация");
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(path + ".xml", FileMode.Open))
            {
                shapes = (Shape[])serializer.Deserialize(fs);
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine($"Фигура {shape}");
                }
            }
            Console.WriteLine("================================");
        }

        private static void JsonSerializeFigur(string path, Shape[] shapes)
        {
            Console.WriteLine("Сериализация");
            var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            using (FileStream fs = new FileStream((path + ".json"), FileMode.Create))
            {
                foreach (Shape shape in shapes)
                {
                    string json = JsonConvert.SerializeObject(shape, jset);
                }
            }
            Console.WriteLine("================================");
        }

        private static void JsonDeserializaFigur(string path, Shape[] shapes)
        {
            var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            Console.WriteLine("Десериализация");
            JsonConvert.DeserializeObject<Shape[]>(File.ReadAllText(path), jset);
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Фигура {shape}");
            }
            Console.WriteLine("==================="); 
        }
    

        private static void Main(string[] args)
        {
            string path = CreateDirectory(@"D:\test2", "figure2");
            //Console.WriteLine("Укажите место создаваемой директории");
            //string directory = Console.ReadLine();
            //Console.WriteLine("Введите название файла");
            //string fileName = Console.ReadLine();
            //string path = CreateDirectory(directory, fileName);
            //Console.Clear();
            //Encoding utf8 = Encoding.UTF8;
            Shape[] shapes = CreateFigure.GetShapes();
            Console.WriteLine("Работа с файлами типа XML");
            XmlSerializeFigur(path, shapes);
            XmlDeserializaFigur(path, shapes);
            Console.WriteLine("Работа с файлами типа JSON");
            JsonSerializeFigur(path, shapes);
            Console.WriteLine("================================");
            JsonDeserializaFigur(path, shapes);
            Console.ReadKey();
        }

    }
}
