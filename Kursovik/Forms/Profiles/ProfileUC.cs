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

namespace Kursovik.Forms.Profiles
{
    public partial class ProfileUC : Form
    {
        public ProfileUC()
        {
            InitializeComponent();
        }

        private void ProfileUC_Load(object sender, EventArgs e)
        {
           lbl_profile_name.Text = lbl_profile_name.Text + " " + Authorisation.uridich_Client.name_company.ToString();
            tb_nameCompany.Text = Authorisation.uridich_Client.name_company;
            tb_adress.Text = Authorisation.uridich_Client.company_adress;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClientFromDb.UpdateUrClient(tb_nameCompany.Text, tb_adress.Text, Authorisation.uridich_Client.client_ur_id);
            Authorisation.uridich_Client = Authorisation.clientFromDb.GetUrClient(Authorisation.uridich_Client.client_ur_id);
            lbl_profile_name.Text = "Ваш профиль -"+  " " + Authorisation.uridich_Client.name_company.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainFormCU mainFormCU = new MainFormCU();
            this.Hide();
            mainFormCU.Show();
        }
    }
}
