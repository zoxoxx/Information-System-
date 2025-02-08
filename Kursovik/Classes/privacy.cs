using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class privacy
    {
      public  int privacyid {  get; set; }
        public string privacy_name { get; set; }
        public privacy(int privacyid, string privacy_name) 
        {
            this.privacyid = privacyid;
            this.privacy_name = privacy_name;
        }
    }
}
