using Kursovik.Classes;
using Kursovik.Model;
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
    public partial class ChangeCategory : Form
    {
        List <document_category> categories = new List <document_category> ();
        public ChangeCategory()
        {
            InitializeComponent();
        }

        private void ChangeCategory_Load(object sender, EventArgs e)
        {
            updateCMB();
            cmb_changeCategory.SelectedValue = 1;
            cmb_changeCategory.SelectedIndex = 0;
        }


        private void updateCMB()
        {
            categories = CategoryDocFromDb.getcategoryDocs();
            cmb_changeCategory.DataSource = categories;
            cmb_changeCategory.DisplayMember = "category_name";
            cmb_changeCategory.ValueMember = "categoryid";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            CategoryDocFromDb.CategoryChange(Convert.ToInt32(cmb_changeCategory.SelectedValue), tb_name.Text, tb_description.Text);
            updateCMB ();
        }

        private void cmb_changeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_changeCategory.SelectedValue != null)
            {
                if (int.TryParse(cmb_changeCategory.SelectedValue.ToString(), out int id))
                {
                    foreach (document_category category in categories)
                    {
                        if (category.categoryid == id)
                        {
                            tb_name.Text = category.category_name;
                            tb_description.Text = category.descriptor_category;
                            break; 
                        }
                    }
                }
                
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CategoryDocFromDb.CategoryDelete(Convert.ToInt32(cmb_changeCategory.SelectedValue));
            updateCMB();
        }
    }
}
