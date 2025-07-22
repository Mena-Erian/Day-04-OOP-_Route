using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class DataBase
    {
        public User[]? Users { get; set; }
        public DataBase() => GetUsers();
        private User[] GetUsers()
        {
            Users = new User[] {
            new User(Role.Manger) { UserName = "Mena", Password = "pas123"  },
            new User(Role.Employee) { UserName = "Hamda", Password = "fasfe" },
            new User(Role.Employee) { UserName = "Helal", Password = "pas123" },
            new User(Role.Employee) { UserName = "Mona", Password = "pas123" },
            new User(Role.Customer) { UserName = "Manar", Password = "pas123" },
            new User(Role.Customer) { UserName = "Mark", Password = "pas123" },
            new User(Role.Customer) { UserName = "Khaled", Password = "pas123" },
            new User(Role.Customer) { UserName = "Omar", Password = "pas123" },
            new User(Role.Customer) { UserName = "Mohammed", Password = "pas123" },
            new User(Role.Customer) { UserName = "Kerolos", Password = "pas123" }
                 };
            return Users;
        }
    }
}
