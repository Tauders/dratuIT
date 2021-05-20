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
            Shape[] figure = CreatFigure.GetShapes();
            XmlSerializer write = new XmlSerializer(typeof(Shape[]));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Figure2.xml";
            FileStream file = File.Create(path);

            write.Serialize(file, figure);
            file.Close();
        }
    }
}
