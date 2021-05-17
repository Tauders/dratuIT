using System;

namespace LibFigure
{
    public class Ball : Shape
    {
        private double _r;

        public Ball(double r)
        {
            _r = r;
        }

        public override double Volume() => Math.Round((4 / 3.0) * Math.PI * Math.Pow(_r, 3), 3);

        public override string ToString()
        {
            return "Шар";
        }
    }
}
