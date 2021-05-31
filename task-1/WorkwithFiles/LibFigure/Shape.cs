using System;
using System.Xml.Serialization;


namespace LibFigure
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
        public abstract double Volume();
    }
}
