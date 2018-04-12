using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassArea
{
    class Rectangle : ICalArea
    {
        private double Height;
        private double Width;
        public double GetArea()
        {
            return Height * Width;
        }

        public double GetPerimetor()
        {
            return 2 * Height + 2 * Width;
        }
        public Rectangle(double h,double w)
        {
            Height = h;
            Width = w;
        }
    }
}
