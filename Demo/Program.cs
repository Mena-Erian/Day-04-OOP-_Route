//using Demo.Interface_Example_01;
using Demo.Built_in_Interfaces;
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

            #region Why Clone Method Says it Makes a Shallow Copy
            /// string[] Names01 = ["Amr", "Mona"];
            /// string[] Names02 = ["Ahmed", "Yassmin"];
            /// 
            /// Console.WriteLine($"Arr01.GetHashCode() => {Names01.GetHashCode()}"); // Based in his place in heap
            /// Console.WriteLine($"Arr02.GetHashCode() => {Names02.GetHashCode()}");
            /// 
            /// Names02 = (string[])Names01.Clone(); Console.WriteLine("After Deep Copy -->  Names02 = (string[])Names01.Clone()");
            /// // Clone Method: Will Generate New Object with NEW and DIFFERENT Identity
            /// //             : This Object Will Have the Same State[Date] of the Original Object [Shallow Copy for the items]
            /// Console.WriteLine($"Arr01.GetHashCode() => {Names01.GetHashCode()}"); // Based in his place in heap
            /// Console.WriteLine($"Arr02.GetHashCode() => {Names02.GetHashCode()}");
            /// 
            /// Names02[0] = new string("Khalid");
            /// Console.WriteLine(Names01[0]); // Amr 
            #endregion

            #region Built-In Interfaces ICloneable
            /// Employee employee1 = new Employee() { Id = 10, Name = "Ahmed", Salary = 8_000, Department = new Department() { Code = 1001, Title = "Sales" } };
            /// Employee employee2 = new Employee() { Id = 20, Name = "Omnia", Salary = 4_000, Department = new Department() { Code = 2002, Title = "HR" } };
            /// 
            /// Console.WriteLine($"employee1.GetHashCode() = {employee1.GetHashCode()}");
            /// Console.WriteLine($"employee2.GetHashCode() = {employee2.GetHashCode()}");
            /// 
            /// //  employee2 = (Employee)employee1.Clone();
            /// // 2. Deep Copy Using Clone 
            /// // Clone Method: This Method Generetes NEW Object With NEW and DIFFERENT Idintity 
            /// //             : This Object Will Have the Same State[Data] of the Caller Object
            /// 
            /// // Another to Make Depp Copy
            /// employee2 = new Employee(employee1); // 2.1 Deep Copy Using Clone Method
            /// 
            /// 
            /// Console.WriteLine("After Deep Copy");
            /// 
            /// 
            /// 
            /// //employee2.Salary = 10000;
            /// 
            /// if (employee2.Department is not null)
            ///     employee2.Department.Title = "NEW";
            /// 
            /// employee2.Salary = 6_000;
            /// employee2.Name = "test";
            /// 
            /// 
            /// Console.WriteLine($"employee1.GetHashCode() = {employee1.GetHashCode()}");
            /// Console.WriteLine($"employee2.GetHashCode() = {employee2.GetHashCode()}");
            /// 
            /// Console.WriteLine($"Emp 01 = ${employee1}");
            /// Console.WriteLine($"Emp 02 = ${employee2}"); 
            #endregion


            #region Built-In Interface ICompareable, IComparer
            /// Employee[] employees =
            /// {
            ///     new Employee(){Id = 20,Name = "Ahmed",Salary=8_000},
            ///     new Employee(){Id = 30,Name = "Omnia",Salary=2_000},
            ///     new Employee(){Id = 10,Name = "Nadia",Salary=10_000},
            ///     new Employee(){Id = 40,Name = "Omars",Salary=6_000},
            /// };
            /// 
            /// //Array.Sort(employees);
            /// Array.Sort(employees,new EmployeeComparer());
            /// 
            /// foreach (Employee employee in employees)
            ///     Console.WriteLine(employee);
            /// 
            /// //int Result = employees[0].CompareTo("Hamda"); // it Will Throw Exception
            #endregion

            #region Sort Array of Integer
            /// int[] Numbers = [9, 2, 59, 32, 5, 4, 8, 1, 65, 3, 5];
            /// 
            /// Array.Sort(Numbers, new IntegerComparers());
            /// 
            /// foreach (int i in Numbers)
            ///     Console.WriteLine(i); 
            #endregion

        }
    }
}
