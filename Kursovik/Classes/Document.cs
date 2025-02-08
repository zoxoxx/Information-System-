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
        public string type { get; set; }
        public int bookshell_number { get; set; }
        public int row_number { get; set; }
        public DateTime create_datetime { get; set; }
        public string creator { get; set; }
        public string filepath { get; set; }
        public string category { get; set; }
        public int privacyid { get; set; }
        public string availability { get; set; }
        public string name { get; set; }

        public Document(int documentid, string type, int bookshell_number, int row_number, DateTime create_datetime, string creator, string filepath, string category, int privacyid, string availability, string name)
        {
            this.documentid = documentid;
            this.type = type;
            this.bookshell_number = bookshell_number;
            this.row_number = row_number;
            this.create_datetime = create_datetime;
            this.creator = creator;
            this.filepath = filepath;
            this.category = category;
            this.privacyid = privacyid;
            this.availability = availability;
            this.name = name;
        }
    }
}
