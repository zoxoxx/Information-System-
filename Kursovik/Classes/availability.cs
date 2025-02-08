using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class availability
    {
      public  int id {  get; set; }
        public string name { get; set; }
        public availability(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
