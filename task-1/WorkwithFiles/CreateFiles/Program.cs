using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using LibFigure;
using System.Xml.Serialization;
using System.Text;

namespace CreateFiles
{
    class Program
    {
        private static void SerializeFigur(string filename)
        {
            Shape[] shape = CreatFigure.GetShapes();
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, shape);
            Console.WriteLine("================");
            Console.WriteLine("Шалость удалась");
        }

        private static void DeserializaFigur() 
        { 

        }

        private static void Main(string[] args)
        {
            SerializeFigur("Figur.xml");

            Console.ReadKey();
        }
    }
}
