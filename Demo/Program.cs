//using Demo.Interface_Example_01;
using Demo.Interface_Example_02;

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


        }
    }
}
