using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSimplePoint
{
    class Circle:Point
    {
        int r;
        public Circle(int x, int y, int r): base(x, y)
        {
            this.r = r;
        }

        public double Area
        {
            get { return Math.PI*r*r; }
        }

    }
}
