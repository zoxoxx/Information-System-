using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class type_document
    {
       public int typeid {  get; set; }
        public string type_name { get; set; }
        public type_document(int typeid, string type_name) 
        {
          this.typeid = typeid;
          this.type_name = type_name;
        }
    }
}
