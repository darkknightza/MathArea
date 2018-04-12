using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassArea
{
    class Circle : ICalArea
    {
        private double Redius;
        public double GetArea()
        {
            return 3.14 * Redius * Redius;
        }

        public double GetPerimetor()
        {
            return 2 * 3.14 * Redius;
        }
        public Circle(double r)
        {
            Redius = r;
        }
    }
}
