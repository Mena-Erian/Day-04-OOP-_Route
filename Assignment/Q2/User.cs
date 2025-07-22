using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class User : IComparable<User>
    {

        public User()
        {
            Role = Role.Customer;
        }
        public User(Role role)
        {
            Role = role;
        }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int Number { get; set; }
        public Role Role { get; set; }

        public int CompareTo(User? other)
        {
            if (other is null) return 1;
            if ((this?.UserName ?? string.Empty) == (other?.UserName ?? string.Empty) &&
                (this?.Password ?? string.Empty) == (other?.Password ?? string.Empty)
                ) return 0;
            else return -1;
        }
    }
}
