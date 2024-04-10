using System;
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
    public partial class RegistrationType : Form
    {
        public RegistrationType()
        {
            InitializeComponent();
        }

        private void btn_physReg_Click(object sender, EventArgs e)
        {
            RegistrationPhys reg = new RegistrationPhys();
            this.Hide();
            reg.ShowDialog();
        }

        private void btn_urReg_Click(object sender, EventArgs e)
        {
            RegistrationUr reg = new RegistrationUr();
            this.Hide();
            reg.ShowDialog();
        }
    }
}
