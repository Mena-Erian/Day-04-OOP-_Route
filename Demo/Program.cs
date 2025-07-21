using Demo.Interface_Example_01;

namespace Demo
{
    internal class Program
    {
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



            #endregion

        }
    }
}
