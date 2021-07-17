using System;
using System.IO;
using LibShapes;
using System.Xml.Serialization;
using Newtonsoft.Json;
using CsvHelper;
using System.Text;
using CsvHelper.Configuration;
using System.Globalization;

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
            Console.WriteLine("Объект создан");
            Console.WriteLine("================================");
        }

        private static Shape[] XmlDeserializeFigur(string path)
        {
            Console.WriteLine("Десериализация");
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(path + ".xml", FileMode.Open))
            {
                Shape[] shapes = (Shape[])serializer.Deserialize(fs);
                return shapes;
            }
        }

        private static void JsonSerializeFigur(string path, Shape[] shapes, JsonSerializerSettings jset)
        {
            Console.WriteLine("Сериализация");
            File.WriteAllText(path + ".json", JsonConvert.SerializeObject(shapes, jset));
            Console.WriteLine("Объект создан");
            Console.WriteLine("================================");
        }

        private static Shape[] JsonDeserializeFigur(string path, JsonSerializerSettings jset)
        {
            Console.WriteLine("Десериализация");
            Shape[] shapes = JsonConvert.DeserializeObject<Shape[]>(File.ReadAllText(path + ".json"), jset);
            return shapes;
        }

        private static void CsvSerializeFigur(string path, Shape[] shapes, CsvConfiguration config)
        {
            Console.WriteLine("Сериализация");
            using (StreamWriter sw = new StreamWriter(path + ".csv"))
            {
                using (CsvWriter csv = new CsvWriter(sw, config))
                {
                    csv.WriteRecords(shapes);
                }
                Console.WriteLine("Объект создан");
            }
            Console.WriteLine("================================");
        }

        private static Shape[] CsvDeserializeFigur(string path, CsvConfiguration config)
        {
            Console.WriteLine("Десериализация");
            using (StreamReader sr = new StreamReader(path + ".csv"))
            {
                using (CsvReader csv = new CsvReader(sr, config))
                {
                    var shapes = csv.GetRecords<Shape[]>();
                    return (Shape[])shapes;
                }
            }
            
        }

        private static void Test(Shape[] shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Фигура {shape} и её объём равен: {shape.Volume()}");
            }
            Console.WriteLine("======================================================");
        }


        private static void Main(string[] args)
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8,
                IgnoreBlankLines = false,
                HasHeaderRecord = false,
                Delimiter = ";"
            };
            JsonSerializerSettings jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Objects };
            //Console.WriteLine("Введите название файла");
            string fileName = "tester"; //Console.ReadLine();
            string path = CreateDirectory(@"D:/Figures",fileName);
            //Console.WriteLine("Укажите место создаваемой директории");
            //string directory = Console.ReadLine();
            //Console.Clear();
            //string path = CreateDirectory(directory, fileName);
            Shape[] shapes = CreateFigure.GetShapes();
            Console.WriteLine("Работа с файлами типа XML");
            XmlSerializeFigur(path, shapes);
            Shape[] XmlShapes = XmlDeserializeFigur(path);
            Console.WriteLine("Работа с файлами типа JSON");
            JsonSerializeFigur(path, shapes, jset);
            Shape[] JsonShapes = JsonDeserializeFigur(path, jset);
            Console.WriteLine("Работа с файлами типа CSV");
            CsvSerializeFigur(path, shapes, config);
            Test(XmlShapes);
            Test(JsonShapes);
            //CsvDeserializeFigur(path, config);




           

            //using (StreamWriter sw = new StreamWriter(path + ".csv"))
            //{
            //    using (CsvWriter csv = new CsvWriter(sw, config))
            //    {
            //        csv.WriteRecords(shapes);
            //    }
            //}
            //Console.WriteLine("=====================================");

            //using (StreamReader sr = new StreamReader(path + ".csv"))
            //{
            //    using (CsvReader csv = new CsvReader(sr, config))
            //    {
            //        var shapes = csv.GetRecords<Shape[]>();
            //    }
            //}



            Console.ReadKey();
        }

    }
}
