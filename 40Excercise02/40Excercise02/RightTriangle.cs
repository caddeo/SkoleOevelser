using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise02
{
    class RightTriangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public RightTriangle(double h, double w)
        {
            this.Height = h;
            this.Width = w;
        }

        public RightTriangle()
            : this(0, 0)
        {
                
        }

        public double Area()
        {
            return (Height * Width) / 2;
        }

        public double Circumference()
        {
            return Math.Sqrt((Width * Width) + (Height + Height)) + Height + Width;
        }
    }
}
