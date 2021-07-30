using System;
using System.IO;
using LibShapes;
using Newtonsoft.Json;
using CsvHelper;
using System.Text;
using CsvHelper.Configuration;
using System.Globalization;

namespace CreateFiles
{
    class Program
    {
        private static void CsvDeserializeFigur(Shape[] shapes, string path, CsvConfiguration config)
        {
            Console.WriteLine("Десериализация");
            using (StreamReader sr = new StreamReader(path + ".csv"))
            {
                using (CsvReader csv = new CsvReader(sr, config))
                {
                    StringBuilder st = new StringBuilder();
                    st.AppendLine("Name, Radius, Height, Area");
                    foreach (Shape shape in shapes) ;

                }
            }
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
            //JsonSerializerSettings jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Objects };
            //Console.WriteLine("Введите название файла");
            string fileName = "tester"; //Console.ReadLine();
            string path = Serialization.CreateDirectory(@"D:/Figures", fileName);
            Shape[] shapes = CreateFigure.GetShapes();
            //Console.WriteLine("Работа с файлами типа XML");
            //Serialization.XmlSerializeFigur(path, shapes);
            //Shape[] XmlShapes = Deserialization.XmlDeserializeFigur(path);
            //Console.WriteLine("Работа с файлами типа JSON");
            //Serialization.JsonSerializeFigur(path, shapes, jset);
            //Shape[] JsonShapes = Deserialization.JsonDeserializeFigur(path, jset);
            Console.WriteLine("Работа с файлами типа CSV");
            Serialization.CsvSerializeFigur(path, shapes, config);
            //CsvDeserializeFigur(path, config);

            Console.ReadKey();
        }

    }
}
