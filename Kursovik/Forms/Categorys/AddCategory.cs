﻿using Kursovik.Model;
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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CategoryDocFromDb.CategoryAdd(tb_name.Text, tb_description.Text);
            Choice_category choice_Category = new Choice_category();
            this.Hide();
            choice_Category.Show();
        }
    }
}
