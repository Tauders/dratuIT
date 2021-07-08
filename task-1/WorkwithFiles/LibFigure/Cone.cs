using System;

namespace LibShapes
{
    [Serializable]
    public class Cone : Shape
    {
        public double H { get; set; }
        public double R { get; set; }

        public Cone(double h, double r)
        {
            H = h;
            R = r;
        }

        public Cone()
        {

        }

        public override double Volume()
        {
            return Math.Round((Math.PI * Math.Pow(R, 2) * H) / 3, 3);
        }

        public override string ToString()
        {
            return "Конус";
        }
    }
}


