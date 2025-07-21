using demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface ITwo : IOne,IThree
    {
        public int TwoId { get; set; }
        public string TwoName { get; set; }
        void testtt()
        {
            OneId = 1;
            TwoId = 2;
            TId = 3;
        }
    }
}
