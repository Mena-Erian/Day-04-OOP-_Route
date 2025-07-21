using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }

        public Employee()
        {

        }
        public Employee(Employee employeeCopy)
        {
            this.Id = employeeCopy.Id; // also here when change in one not change in two becouse its value type
            this.Name = employeeCopy.Name;// Address // but when change in one not change in two string(Imutable type)
                                          //Name = (string?)this.Name?.Clone(),  // Make new place in heap but we have CLR enhansment that if the same it will be not make new place
            this.Salary = employeeCopy.Salary; // also here when change in one not change in two becouse its value type
                                               // Shallow Copy
            ///  Department = this.Department // you give the Reference(Address) of object so
            /// when change in one it will be changed in two // and that named (SHALLOW COPY)
            this.Department = (Department?)employeeCopy.Department?.Clone();
            // here you Maked DEEP COPY (USING Clone Method)
        }

        public object Clone()
        {
            /// return new Employee()
            /// {
            ///     Id = this.Id, // also here when change in one not change in two becouse its value type
            ///     Name = this.Name,// Address // but when change in one not change in two string(Imutable type)
            ///     //Name = (string?)this.Name?.Clone(),  // Make new place in heap but we have CLR enhansment that if the same it will be not make new place
            ///     Salary = this.Salary, // also here when change in one not change in two becouse its value type
            ///     // Shallow Copy
            ///     ///  Department = this.Department // you give the Reference(Address) of object so
            ///     /// when change in one it will be changed in two // and that named (SHALLOW COPY)
            ///     Department = (Department?)this.Department?.Clone()
            ///     // here you Maked DEEP COPY (USING Clone Method)
            /// };

            return new Employee(this); // new Employee(employee1)
        }
        public int CompareTo(object? obj)
        {
            /// for (int i = 0; i < employees.Length; i++)
            /// {
            ///     for (int j = 0; j < employees.Length - i - 1; j++)
            ///     {
            ///         if (employees[j].CompareTo(employees[j + 1]) = 1)
            ///             SWAP(employees[j], employees[j + 1]);
            ///     }
            /// }

            Employee? other = (Employee?)obj; // Explicit Casting
                                              // UnSafe Casting [May Throw Exception] (is or as)
            /// if (other is null) return 1;
            /// 
            /// if (this.Salary > other?.Salary) return 1;
            /// if (this.Salary < other?.Salary) return -1;
            /// return 0;

            return this.Salary.CompareTo(other?.Salary);
            //return - this.Salary.CompareTo(other?.Salary);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:c}, Department: {Department?.Title}, {Department?.Code}";
        }

    }
}
