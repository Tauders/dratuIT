using System;
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
        protected string _shapeName;
        public abstract double Volume();
       
    }
}
