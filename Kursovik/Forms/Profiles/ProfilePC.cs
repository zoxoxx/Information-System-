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
    public partial class ProfilePC : Form
    {
        public ProfilePC()
        {
            InitializeComponent();
        }

        private void ProfilePC_Load(object sender, EventArgs e)
        {
            lbl_profileName.Text = "Мой профиль - " + Authorisation.physical_Client.surname + " " + Authorisation.physical_Client.name;
            tb_adress.Text = Authorisation.physical_Client.adress;
            tb_datePassport.Text = Authorisation.physical_Client.date_passport.ToString();
            tb_name.Text = Authorisation.physical_Client.name;
            tb_surname.Text = Authorisation.physical_Client.surname;
            tb_patronymic.Text = Authorisation.physical_Client.patronymic;
            tb_passport.Text = Authorisation.physical_Client.passport;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainFormCPhys mainFormCPhys = new MainFormCPhys();
            this.Hide();
            mainFormCPhys.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClientFromDb.UpdatePhysClient(tb_passport.Text, Convert.ToDateTime(tb_datePassport.Text), tb_surname.Text, tb_name.Text, tb_patronymic.Text, tb_adress.Text, Authorisation.physical_Client.client_phys_id);
            Authorisation.physical_Client = Authorisation.clientFromDb.GetPhysClient(Authorisation.physical_Client.client_phys_id);
            lbl_profileName.Text = "Мой профиль - " + Authorisation.physical_Client.surname + " " + Authorisation.physical_Client.name;
        }
    }
}
