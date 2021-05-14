using System;

namespace CreateFiles
{
    public class Cube: Shape
    {
        private double _r;

        public Cube(double r)
        {
            _r = r;
        }

        public override double Volume()
        {
            double V = Math.Pow(_r, 3);
            return V;
        }

        public override string ToString()
        {
            return "Куб";
        }
    }
}
