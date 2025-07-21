//using Demo.Interface_Example_01;
using Demo.Interface_Example_02;
using Demo.Interface_Example_03;

namespace Demo
{
    internal class Program
    {
        #region Interface Example 02
        static void PrintTenNumbersFromSeries(ISeries series)
        {
            if (series is null)
                return;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        #endregion
        static void Main()
        {
            #region Interface Example 01
            /// IType reference;
            /// // Declare for Reference of type "IType", Containg Garbag value
            /// // This reference 'type' Can Refer to an Object of any "Type Implementiong IType Interfase"
            /// // CLR will Allocate 4 UnInitialized Bytes in STACK for this Reference.
            /// // CLR Will Allocate 0 Bytes in HEAP
            /// 
            /// //reference = /*new IType() */  --> INVALID;
            /// 
            /// reference = new TypeA();
            /// 
            /// reference.MyProperty = 10;
            /// reference.MyMothed();
            /// reference.Print();  // Default Implemented Mehtod
            /// 
            /// 
            /// 
            /// TypeA typeA = new TypeA();
            /// 
            /// typeA.MyProperty = 20;
            /// typeA.MyMothed();
            /// typeA.Print();  // can't ACCESS this just access from interface reference
            #endregion

            #region Interface Example 02
            /// TypeA seriesByTwo = new TypeA();
            /// PrintTenNumbersFromSeries(seriesByTwo);
            /// 
            /// TypeB seriesByThree = new TypeB();
            /// PrintTenNumbersFromSeries(seriesByThree);
            /// 
            /// TypeC seriesByFour = new TypeC();
            /// PrintTenNumbersFromSeries(seriesByFour);
            #endregion

            #region Interface Example 03
            /// Airplane airplane = new Airplane();
            /// airplane.Speed = 480;
            /// //airplane.Frowerd();
            /// 
            /// IMoveable moveable = airplane;
            /// moveable.Forward();
            /// 
            /// IFlyable flyable = airplane;
            /// flyable.Forward();
            #endregion

            #region Shallow Copy VS Deep Copy
            /// int[] Arr01 = [1, 2, 3];
            /// int[] Arr02 = [4, 5, 6];
            /// 
            /// Console.WriteLine($"Arr01.GetHashCode() => {Arr01.GetHashCode()}"); // Based in his place in heap
            /// Console.WriteLine($"Arr02.GetHashCode() => {Arr02.GetHashCode()}");

            #region Shallow Copy
            /// Arr02 = Arr01;
            /// /// Shallow Copy [سطحى]
            /// /// This Object [1, 2, 3] has 2 Reference [Arr01 , Arr02]
            /// /// This Object [4, 5, 6] Became UnReachable Object
            /// Console.WriteLine($"Arr01.GetHashCode() => {Arr01.GetHashCode()}"); // Based in his place in heap
            /// Console.WriteLine($"Arr02.GetHashCode() => {Arr02.GetHashCode()}");
            /// 
            /// Arr02[0] = 100;// after shallow copy change in arr02 it will be changed in original also (arr01)
            /// Console.WriteLine(Arr01[0]); // 100
            #endregion

            #region Deep Copy
            /// Arr02 = (int[])Arr01.Clone();
            /// Console.WriteLine("Deep Copy --> Arr02 = (int[])Arr01.Clone();");
            /// // Deep Copy
            /// // Clone Method: Will Generate NEW Object with NEW and DIFFERENT Identity
            /// //             : This Object Will Have The Same State [Data] of the Caller Object
            /// 
            /// Console.WriteLine($"Arr01.GetHashCode() => {Arr01.GetHashCode()}"); // Based in his place in heap
            /// Console.WriteLine($"Arr02.GetHashCode() => {Arr02.GetHashCode()}");
            /// 
            /// Arr02[0] = 100;// after Deep copy change in arr02 it will be not changed in original (arr01)
            /// Console.WriteLine(Arr01[0]); // 1
            /// Console.WriteLine("-------------------");
            /// for (int i = 0; i < Arr01.Length; i++)
            /// {
            ///     Console.WriteLine(Arr01[i]); // 1
            /// }
            /// Console.WriteLine("******************************");
            /// for (int i = 0; i < Arr02.Length; i++)
            /// {
            ///     Console.WriteLine(Arr02[i]); // 1
            /// }
            #endregion
            #endregion



        }
    }
}
