using System;

namespace LibShapes
{
    public class Pyramid : Shape
    {
        private double _s;
        private double _h;
        
        public Pyramid(double s, double h)
        {
            _s = s;
            _h = h;
        }

        public Pyramid()
        {
           
        }

        public override double Volume() => Math.Round(((_s * _h) / 3), 3);

        public override string ToString()
        {
            return _shapeName = "Пирамида";
        }
    }
}
