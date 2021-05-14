using System;

namespace CreateFiles
{
    public class Cylinder : Shape
    {
        private double _h;
        private double _r;

        public Cylinder(double h, double r)
        {
            _h = h;
            _r = r;
        }

        public override double Volume()
        {
            double V = Math.PI * Math.Pow(_r, 2) * _h;
            return V;
        }

        public override string ToString()
        {
            return "Цилиндр";
        }
    }
}
