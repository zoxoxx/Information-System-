using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Order
    {
        public int getid {  get; set; }
        public int clientid { get; set; }
        public int userid { get; set; }
        public DateTime date_get { get; set; }
        public int statusid { get; set; }
        public int documentid { get; set; }

        public Order(int getid, int clientid, int userid, DateTime date_get, int statusid, int documentid)
        {
            this.getid = getid;
            this.clientid = clientid;
            this.userid = userid;
            this.date_get = date_get;
            this.statusid = statusid;
            this.documentid = documentid;
        }
    }
}
