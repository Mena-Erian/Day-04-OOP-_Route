using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    // Developer --> 1
    internal interface IType
    {

        // 'public' is the Default Access Modifier inside the interface.
        // 'private' is not allowed for the Signature Only (Property, Method)


        // What you can write inside the Interface?

        // 1. Signature for Property
        public int MyProperty { get; set; }
        
        // 2. Signature for Method
        public void MyMothed();

        ///--------

        // 3. Default Implmented Method [C# 8.0 NEW Feature (.NET Core 3.1 [2019])] (private allowed here)
        public void Print()
        {
            Console.WriteLine("Default Implmented Method");
        }

        // 4. Static Members Static( Fields, Properties, Methods, Events ) [C# 8.0 NEW Feature (.NET Core 3.1 [2019])]


    }
}
