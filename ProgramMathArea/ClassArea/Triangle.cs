using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassArea
{
    class Triangle : ICalArea
    {
        private double Height;
        private double Width; 
        public double GetArea()
        {
           return 0.5 * Height * Width;
        }

        public double GetPerimetor()
        {
            return Height + Width + (System.Math.Sqrt(Height*Height+Width*Width));
        }
        public Triangle(double height,double width)
        {
            Height = height;
            Width = width;
            
        }
    }

}
