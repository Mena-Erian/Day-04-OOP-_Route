using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(User user);
        bool AuthorizeUser(User user);
    }
}
