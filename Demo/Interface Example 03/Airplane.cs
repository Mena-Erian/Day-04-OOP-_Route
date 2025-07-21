using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    internal class Airplane : Vechile, IMoveable, IFlyable
    {
        void IMoveable.Forward()
        {
            Console.WriteLine("Airplane is Move Forward On Ground");
        }
        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane is Move Forward On Airrr");
        }
        public void Backward()
        {
            Console.WriteLine("Airplane is Move Backward On Airrr");
        }
        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }
        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
