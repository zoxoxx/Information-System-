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

namespace Kursovik.Forms
{
    public partial class RegistrationUr : Form
    {
        MyMessageBox myMessageBox = new MyMessageBox();
        ClientFromDb clientFromDb = new ClientFromDb();
        public static Client currentClient { get; set; } = null;
        public RegistrationUr()
        {
            InitializeComponent();
        }

        private void btn_endReg_Click(object sender, EventArgs e)
        {
            if (tb_adressCompany.Text!="" && tb_email.Text!="" && tb_nameCompany.Text!="" && tb_phone.Text!="" && tb_password.Text!="" && tb_podPas.Text!="")
            {
                if (tb_password.Text==tb_podPas.Text) 
                {
                    clientFromDb.ClientAdd(1, tb_phone.Text, tb_email.Text, tb_password.Text);
                    currentClient = clientFromDb.GetClient(tb_email.Text, tb_password.Text);
                    if (currentClient!=null)
                    {
                        clientFromDb.UrAdd(tb_nameCompany.Text, tb_adressCompany.Text, currentClient.clientid);
                        Authorisation authorisation = new Authorisation();
                        this.Hide();
                        authorisation.Show();
                    }
                }
                else
                {
                    myMessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                myMessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}
