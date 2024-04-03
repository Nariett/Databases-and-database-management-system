using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNode.Classes
{
    class User
    {
        public string login { get; set; } //Логин пользователя
        public string password { get; set; } // Пароль пользователя
        public User() { }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
