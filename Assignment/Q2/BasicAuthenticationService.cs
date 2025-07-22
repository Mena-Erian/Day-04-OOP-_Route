using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService, IComparable
    {
        public BasicAuthenticationService(DataBase dataBase)
        {
            DataBase = dataBase;
        }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DataBase DataBase { get; set; }

        public bool AuthenticateUser(User user)
        {
            for (int i = 0; i < DataBase?.Users?.Length; i++)
            {
                if (user.CompareTo(DataBase.Users[i]) == 0) return true;
            }
            Console.WriteLine("User InValid or Not Found");
            return false;
        }

        public bool AuthorizeUser(User user)
        {
            // Check is Employee or Manger
            UserComparers roleComparers = new UserComparers();

            if (roleComparers.Compare(new User(Role.Employee), user) == -1)
            {
                return false;
            }
             return true;
        }

        public int CompareTo(object? obj)
        {
            User? other = new User();

            if (other is null) return 1;
            if ((this?.UserName ?? string.Empty) == (other?.UserName ?? string.Empty) &&
                (this?.Password ?? string.Empty) == (other?.Password ?? string.Empty)
                ) return 0;
            else return -1;
        }


    }
}
