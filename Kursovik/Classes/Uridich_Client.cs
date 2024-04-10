using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Uridich_Client
    {
        public string name_company {  get; set; }
        public string company_adress { get; set; }
        public int client_ur_id { get; set; }
        public int typeid { get; set; }

        public Uridich_Client(string name_company, string company_adress, int client_ur_id, int typeid)
        {
            this.name_company = name_company;
            this.company_adress = company_adress;
            this.client_ur_id = client_ur_id;
            this.typeid = typeid;
        }
    }
}
