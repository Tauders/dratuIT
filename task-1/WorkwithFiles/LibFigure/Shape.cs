using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;


namespace LibShapes
{
    [XmlInclude(typeof(Cube)),
    XmlInclude(typeof(Cylinder)),
    XmlInclude(typeof(Pyramid)),
    XmlInclude(typeof(Ball)),
    XmlInclude(typeof(Cone)),
    XmlInclude(typeof(Prism))]
    [Serializable]

    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract double Volume();

        public Shape()
        {

        }
    }

}
