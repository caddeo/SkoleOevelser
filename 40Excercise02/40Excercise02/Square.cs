using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise02
{
    class Square
    {

        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public double Circumference()
        {
            return (Width + Width + Height + Height);
        }

    }
}
