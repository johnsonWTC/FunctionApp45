using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp43
{
   public interface ICrud
    {
        string AddUser(User user);
        string DeleteUser(User user);
        string FindUser(int userID);
        string UpdateUser(string newUserName, int userID);
    }
}
