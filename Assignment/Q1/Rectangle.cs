using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1
{
    internal class Rectangle : IRectangle
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public double Area { get; private set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width = {Width}");
            Console.WriteLine($"Height = {Height}");
            Console.WriteLine($"Area = Width * Height = {Width} * {Height} = {CalcArea()} ");
        }
        double CalcArea()
        {
            return Area = Width * Height;
        }
    }
}
