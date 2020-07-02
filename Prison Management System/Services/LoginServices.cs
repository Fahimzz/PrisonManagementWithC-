using Prison_Management_System.Entities;
using Prison_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Services
{
    class LoginServices
    {
        UserRepo userrepo;
        public LoginServices()
        {
            userrepo = new UserRepo();
        }
        public int LoginValidation(string userid, string password)
        {
            return userrepo.GetUser(new User() { UserId = userid, Password = password });
        }
        public int insertUser(string id,string password, int status)
        {
            return userrepo.insert(new User() { UserId = id, Password = password, Status = status }); 
        }
        public int deleteUser(string id)
        {
            int result = userrepo.Delete(id);
            return result;
        }
        public int Updatepass(string userid,string password)
        {
            int result = userrepo.Update(new User() { UserId = userid, Password = password });
            return result;
        }
        public int Validation(string userid, string password)
        {
            return userrepo.GetUserforpass(new User() { UserId = userid, Password = password });
        }
    }
}
