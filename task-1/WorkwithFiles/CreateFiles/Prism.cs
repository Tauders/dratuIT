using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFiles
{
    public class Prism: Shape
    {
        private double _h;

        public Prism(double h)
        {
            _h = h;
        }

        public override double Volume()
        {
            double V = (Math.Pow(_h, 2) * Math.Sqrt(3) / 2) * ((_h * 4) / 2);
            return V;
        }

        public override string ToString()
        {
            return "Призма";
        }
    }
}
