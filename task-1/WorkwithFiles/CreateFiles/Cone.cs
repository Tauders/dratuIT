using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFiles
{
    public class Cone: Shape

     {
            private double _h;
            private double _r;

            public Cone(double h, double r)
            {
                _h = h;
                _r = r;
            }

            public override double Volume()
            {
                double V = (Math.PI * Math.Pow(_r, 2) * _h)/3;
                return V;
            }

            public override string ToString()
            {
                return "Конус";
            }

    }
}


