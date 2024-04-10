using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Client
    {
       public int clientid { get; set; }
        public int typeid { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Client(int Clientid, int Typeid, string Phone, string Email) 
        {
            clientid = Clientid;
            typeid = Typeid;
            phone = Phone;
            email = Email;
        }
    }
}
