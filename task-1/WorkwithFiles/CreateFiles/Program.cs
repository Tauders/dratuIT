using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using LibFigure;
using System.Xml.Serialization;


namespace CreateFiles
{
    class Program
    {
        private static void Main(string[] args)
        {
            Shape[] shape = CreatFigure.GetShapes();
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, shape);
            }
        }
    }
}
