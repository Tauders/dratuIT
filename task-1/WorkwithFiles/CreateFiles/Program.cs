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
        private static void SerializeFigur(string filename)
        {
            Shape[] shape = CreatFigure.GetShapes();
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, shape);
            }
        }

        private static void DeserializaFigur(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                Shape[] shapes = (Shape[])serializer.Deserialize(fs);
            }
        }

        private static void Main(string[] args)
        {
            CreatFigure.GetShapes();
            
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.ReadKey();
        }

        
    }
}
