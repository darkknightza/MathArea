using ConsoleApp1;
using ConsoleApp1.ClassArea;
using System;

namespace ProgramMathArea
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalArea tg = new Triangle(10, 20);
            ICalArea rt = new Rectangle(5, 10);
            ICalArea sq = new Square(10);
            ICalArea el = new Ellipse(10, 30);
            ICalArea ci = new Circle(10);
            Console.WriteLine(tg.GetArea());
            Console.WriteLine(tg.GetPerimetor());
            Console.WriteLine(rt.GetArea());
            Console.WriteLine(rt.GetPerimetor());
            Console.WriteLine(sq.GetArea());
            Console.WriteLine(sq.GetPerimetor());
            Console.WriteLine(el.GetArea());
            Console.WriteLine(el.GetPerimetor());
            Console.WriteLine(ci.GetArea());
            Console.WriteLine(ci.GetPerimetor());


            Console.ReadLine();
        }
    }
}
