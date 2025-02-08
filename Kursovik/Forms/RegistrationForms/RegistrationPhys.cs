using Kursovik.Classes;
using Kursovik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.Forms
{
    public partial class RegistrationPhys : Form
    {
        ClientFromDb clientFromDb = new ClientFromDb();
        public static Client currentClient { get; set; } = null;
        public RegistrationPhys()
        {
            InitializeComponent();
        }

        private void btn_regEnd_Click(object sender, EventArgs e)
        {
            if (tb_adress.Text!= "" && tb_datePassport.Text!="" && tb_passport.Text!="" && tb_email.Text!= "" && tb_name.Text!="" && tb_surname.Text!="" && tb_patronymic.Text!="" && tb_password.Text!="" && tb_podPas.Text!="")
            {
                if (tb_password.Text==tb_podPas.Text)
                {
                    clientFromDb.ClientAdd(1, tb_phone.Text, tb_email.Text, tb_password.Text);
                    currentClient = clientFromDb.GetClient(tb_email.Text, tb_password.Text);
                    if (currentClient != null) 
                    {
                       
                        clientFromDb.PhysAdd(tb_passport.Text, tb_datePassport.Text, tb_surname.Text, tb_name.Text, tb_patronymic.Text, tb_adress.Text, currentClient.clientid);
                        Authorisation authorisation = new Authorisation();
                        this.Hide();
                        authorisation.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}
