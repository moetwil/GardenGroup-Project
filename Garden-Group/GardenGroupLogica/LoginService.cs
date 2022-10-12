using GardenGroupDAL;
using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    public class LoginService
    {
        private PasswordService passwordService;
        private UserDao user;
        public LoginService()
        {
            this.passwordService = new PasswordService();
            this.user = new UserDao();
        }

        public bool CheckPassword(string email, string password)
        {
            User user = this.user.FindUserByEmail(email);
            if (user != null)
            {
                return this.passwordService.VerifyPassword(password, user.Password.Hash, user.Password.Salt);
            }
            return false;
        }
    }
}
