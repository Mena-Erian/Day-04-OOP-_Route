using Assignment.Q1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Assignment.Q1
{
    internal class Circle : ICircle
    {

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area { get; set; }
        public double Radius { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius}");
            Console.WriteLine($"Area = πr^2 = {CalcArea()}");
        }
        double CalcArea()
        {
            return Area = Math.PI * Math.Pow(Radius, 2);
        }
    }
}
