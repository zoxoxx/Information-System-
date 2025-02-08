using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class document_category
    {
        public int categoryid {  get; set; }
        public string category_name { get; set; }
        public string descriptor_category {  get; set; }

        public document_category(int categoryid, string category_name, string descriptor_category)
        {
            this.categoryid = categoryid;
            this.category_name = category_name;
            this.descriptor_category = descriptor_category;
        }

        public document_category() { }

        public document_category(int categoryid, string category_name)
        {
            this.categoryid = categoryid;
            this.category_name = category_name;
        }
    }
}
