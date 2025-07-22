using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class UserComparers : IComparer<User>
    {
        public int Compare(User? basedUser, User? userChecks)
        {
            //Compare Base the Role of User
            // x < y => -1
            // x = y => 0
            // x > y => 1
            return basedUser?.Role > userChecks?.Role ? -1: basedUser?.Role < userChecks?.Role ? 1 : 0 ;
        }
    }
}
