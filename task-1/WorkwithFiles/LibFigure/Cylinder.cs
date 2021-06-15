using System;

namespace LibShapes
{
    public class Cylinder : Shape
    {
        public double H { get; set; }
        public double R { get; set; }

        public Cylinder(double h, double r)
        {
            H = h;
            R = r;
        }

        public Cylinder()
        {

        }

        public override double Volume() 
        {
            return Math.Round((Math.PI * Math.Pow(R, 2) * H), 3);
        } 

        public override string ToString()
        {
            return Name = "Цилиндр";
        }
    }
}
