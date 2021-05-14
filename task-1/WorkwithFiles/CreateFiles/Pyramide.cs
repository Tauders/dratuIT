using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFiles
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

        public override double Volume()
        {
            double V = (_s * _h) / 3;
            return V;
        }

        public override string ToString()
        {
            return "Пирамида";
        }
    }
}
