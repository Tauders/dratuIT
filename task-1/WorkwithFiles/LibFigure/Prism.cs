﻿using System;

namespace LibShapes
{
    public class Prism : Shape
    {
        public double H { get; set; }

        public Prism(double h)
        {
            H = h;
        }

        public Prism()
        {
            
        }

        public override double Volume() 
        {
            return Math.Round((Math.Pow(H, 2) * Math.Sqrt(3) / 2) * ((H * 4) / 2), 3);
        }

        public override string ToString()
        {
            return Name = "Призма";
        }
    }
}
