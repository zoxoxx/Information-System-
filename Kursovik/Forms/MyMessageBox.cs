﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.Forms
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        public void Show(String text)
        {
            label1.Text = text;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
