using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
    internal class Rectangle:IScalable
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public void Scale(double s)
        {
            Width *= s;
            Height *= s;

        }
    }
}
