using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Physical_Client
    {
        public string passport {  get; set; }
        public DateTime date_passport { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string adress { get; set; }
        public int client_phys_id { get; set; }
        public int typeid { get; set; }

        public Physical_Client(string passport, DateTime date_passport, string surname, string name, string patronymic, string adress, int client_phys_id, int typeid)
        {
            this.passport = passport;
            this.date_passport = date_passport;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.adress = adress;
            this.client_phys_id = client_phys_id;
            this.typeid = typeid;
        }
    }
}
