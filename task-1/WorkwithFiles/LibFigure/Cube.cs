using System;

namespace LibShapes
{
    public class Cube : Shape
    { 
        private double _r;
        
        public Cube(double r)
        {
            _r = r;
        }

        public Cube()
        {

        }

        public override double Volume() => Math.Round(Math.Pow(_r, 3), 3);

        public override string ToString()
        {
            return _shapeName = "Куб";
        }
    }
}
