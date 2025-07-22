using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1
{
    internal interface IShape
    {
        public double Area { get; }
        void DisplayShapeInfo();
        //internal double CalcArea();
    }
}
