using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Document
    {
        public int documentid { get; set; }
        public int typeid { get; set; }
        public int bookshell_number { get; set; }
        public int row_number { get; set; }
        public DateTime create_datetime { get; set; }
        public string creator { get; set; }
        public string filepath { get; set; }
        public int categoryid { get; set; }
        public int privacyid { get; set; }
        public int availabilityid { get; set; }
        public string name { get; set; }

        public Document(int documentid, int typeid, int bookshell_number, int row_number, DateTime create_datetime, string creator, string filepath, int categoryid, int privacyid, int availabilityid, string name)
        {
            this.documentid = documentid;
            this.typeid = typeid;
            this.bookshell_number = bookshell_number;
            this.row_number = row_number;
            this.create_datetime = create_datetime;
            this.creator = creator;
            this.filepath = filepath;
            this.categoryid = categoryid;
            this.privacyid = privacyid;
            this.availabilityid = availabilityid;
            this.name = name;
        }
    }
}
