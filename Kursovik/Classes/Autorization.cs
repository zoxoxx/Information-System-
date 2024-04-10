using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Autorization
    {
        public int autorid {  get; set; }
        public DateTime date_time { get; set; }
        public int userid { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
       
        public Image photo { get; set; }

        public Autorization (int autorid, DateTime date_time, int userid, string surname, string name, string image)
        {
            this.autorid = autorid;
            this.date_time = date_time;
            this.userid = userid;
            this.name = name;
            this.surname = surname;
            if (image != "")
                photo = Image.FromFile(image);
            else
                photo = Image.FromFile(@"..\..\Images\picture.jpg");
        }
    }
}
