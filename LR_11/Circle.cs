using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
   
    internal class Circle:IScalable
    {
        public double Radius;

        public Circle(double radius) { 
        Radius = radius;
        }
        public void Scale(double s) {
            Radius *= s;
        }

    }
}
