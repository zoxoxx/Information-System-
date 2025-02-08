using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.Forms.Categorys
{
    public partial class Choice_category : Form
    {
        public Choice_category()
        {
            InitializeComponent();
        }

        private void btn_changeCategory_Click(object sender, EventArgs e)
        {
            ChangeCategory changeCategory = new ChangeCategory();
            this.Hide();
            changeCategory.Show();
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            this.Hide();
            addCategory.Show();
        }

     

        private void Choice_category_Load(object sender, EventArgs e)
        {

        }
    }
}
