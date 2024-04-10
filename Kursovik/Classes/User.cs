using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class User
    {
        public int userid { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public int roleid { get; set; }
        public DateTime birthday { get; set; }

        public User(int Userid, string Email, string Password, string Photo, string Surname, string Name, string Patronymic, int Roleid, DateTime Birthday) 
        {
            userid = Userid;
            email = Email;
            password = Password;
            photo = Photo;
            surname = Surname;
            name = Name;
            patronymic = Patronymic;
            roleid = Roleid;
            birthday = Birthday;
        }   
    }
}
