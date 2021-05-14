using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFiles
{
    public class Ball : Shape
    {
        private double _r;

        public Ball(double r)
        {
            _r = r;
        }

        public override double Volume()
        {
            double V = (4 / 3.0) * Math.PI * Math.Pow(_r, 3);
            return V;
        }

        public override string ToString()
        {
            return "Шар";
        }
    }
}
