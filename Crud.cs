using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp43
{
   public class Crud : ICrud
    {
        private UserContext _userContext = new UserContext();

       
        public string AddUser(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChangesAsync();
            return $"{user.UserName} was added";
        }

        public string DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public string FindUser(int userID)
        {
            throw new NotImplementedException();
        }

        public string UpdateUser(string newUserName, int userID)
        {
            throw new NotImplementedException();
        }
    }
}
