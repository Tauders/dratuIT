using System;
using LibShapes;
using Newtonsoft.Json;

namespace WorkwithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "tester"; //Console.ReadLine();
            string path = Serialization.CreateDirectory(@"D:/Figures", fileName);
            JsonSerializerSettings jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Objects };
            Shape[] Jsonshapes = Deserialization.JsonDeserializeFigur(path, jset);
            Shape[] Xmlshapes = Deserialization.XmlDeserializeFigur(path);
            double xmlresult = 0;
            double jsonresult = 0;

            for (int i = 0; i<Xmlshapes.Length; i++)
            {
                xmlresult += Xmlshapes[i].Volume();
                Console.WriteLine(Xmlshapes[i].Volume());
                
            }
            Console.WriteLine(xmlresult);
            Console.WriteLine("=======================================");
            for (int i = 0; i < Jsonshapes.Length; i++)
            {
                jsonresult += Jsonshapes[i].Volume();
                Console.WriteLine(Jsonshapes[i].Volume());

            }
            Console.WriteLine(jsonresult);


            Console.ReadKey();
        }
    }
}
