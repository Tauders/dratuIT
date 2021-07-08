using System;

namespace LibShapes
{
    [Serializable]
    public class Ball : Shape
    {
        
        public double R { get; set; }
        
        public Ball(double r)
        {
           R = r;
        }

        

        public Ball()
        {

        }

        public override double Volume()
        {
            return Math.Round((4 / 3.0) * Math.PI * Math.Pow(R, 3), 3);
        }

        public override string ToString()
        {
            return Name = "Шар";
        }
    }
}
