using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFiles
{
    class Prism:Shape
    {
        private double _h;
        

        public Prism(double h)
        {
            _h = h;
            
        }

        public override double Volume()
        {
            double perRomb = _h * 4;
            double height = perRomb / 2;
            double sOsn = Math.Pow(_h, 2) * Math.Sqrt(3) / 2;
            double V = sOsn * height;
            return V;
        }

        public override string ToString()
        {
            return "Призма";
        }
    }
}
