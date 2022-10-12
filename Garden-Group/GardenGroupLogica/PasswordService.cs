using GardenGroupDAL;
using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    public class PasswordService
    {
        private const int HashIteration = 10000;
        
        //you can choose the length of the password.
        private const int PasswordLength = 12;
        
        private const string secretPepper = "Ik hou van boter met siroop";
        
        public Password GenerateSaltedHash(int size, string password)
        {
            byte[] saltBytes = new byte[size];
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);

            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password + secretPepper, saltBytes, HashIteration);
            string hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            Password hashSalt = new Password(hashPassword, salt);
            return hashSalt;
        }

        public bool VerifyPassword(string password, string hash, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password + secretPepper, saltBytes, HashIteration);
            string hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            return hashPassword == hash;
        }

        public string generateRandomPassword()
        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[PasswordLength];
            for (int i = 0; i < PasswordLength; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);


        }
    }
}
