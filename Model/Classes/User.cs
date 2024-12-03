using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TorgovoPosredFirma.Model.Classes
{
    public class User
    {
        private string username;
        private string passwordHash;
        private string role;
        public string Username {
            get
            {
                return username;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Имя пользователя не может быть пустым!");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Имя пользователя не может быть длиной больше 50 символов!");
                }
                else
                {
                    username = value;
                }
            }
        }
        public string PasswordHash
        {
            get
            {
                return passwordHash;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Пароль пользователя не может быть пустым!");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Пароль пользователя не может быть длиной больше 50 символов!");
                }
                else
                {
                    passwordHash = HashPassword(value);
                }
            }
        }
        public string Role
        {
            get { return role; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Роль пользователя не может быть пустой!");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Роль пользователя не может быть длиной больше 50 символов!");
                }
                else
                {
                    role = value;
                }
            }
        }
        public static string HashPassword(string password)
        {
            using (var sha256  = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedPasswordBytes);
            }
        }
    }
}
