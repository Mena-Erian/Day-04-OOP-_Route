using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    // Developer --> 2
    class TypeA : IType
    {
        public int MyProperty { get; set; }

        //public int myAttribute;
        //public int MyProperty
        //{
        //    get { return myAttribute; }
        //    set { myAttribute = value; }
        //}
       
        public void MyMothed()
        {
            Console.WriteLine("Hello world!");
        }
    
    }
}
