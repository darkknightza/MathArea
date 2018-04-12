using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassArea
{
    class Ellipse : ICalArea
    {
        private double RediusX;
        private double RediusY;
        private double Pi = 3.14;
        public double GetArea()
        {
            return Pi * RediusX * RediusY;
        }

        public double GetPerimetor()
        {
            return Pi*(RediusX + RediusY);
        }
        public Ellipse(double x, double y)
        {
            RediusX = x;
            RediusY = y;
        }
    }
}
