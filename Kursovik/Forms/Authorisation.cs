using Kursovik.Classes;
using Kursovik.Forms;
using Kursovik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik
{
    public partial class Authorisation : Form
    {
       public static UserFromDb userFromDb = new UserFromDb();
        public static Client currentClient { get; set; } = null;
        public static User currentUser { get; set; } = null;
        public static Physical_Client physical_Client { get; set; } = null;
        public static Uridich_Client uridich_Client { get; set;} = null;
       public static ClientFromDb clientFromDb = new ClientFromDb();
        public Authorisation()
        {
            InitializeComponent();
        }

        private void btn_vhod_Click(object sender, EventArgs e)
        {
            if (!(tb_login.Text != "" && tb_password.Text != ""))
            {
                MessageBox.Show("Введите данные"); return;
            }
            else
            {
                currentUser = userFromDb.GetUser(tb_login.Text, tb_password.Text);
                if (currentUser != null)
                {
                    AutorizationMagazineFromDb.EntranceAdd(currentUser.userid, DateTime.Now);
                    MainForm_Sotrudnik_ mainForm = new MainForm_Sotrudnik_();
                    mainForm.Show();
                    this.Hide();
                }
               else
                {
                    currentClient = clientFromDb.GetClient(tb_login.Text, tb_password.Text);
                    if (currentClient != null)
                    {
                        //разделение на 1- физ лицо и 2-юридическое лицо
                        if(currentClient.typeid == 1)
                        {
                            physical_Client = clientFromDb.GetPhysClient(currentClient.clientid);
                            if (physical_Client != null)
                            {
                                MainFormCPhys vhod = new MainFormCPhys();
                                this.Hide();
                                vhod.Show();
                            }
                        }
                        else
                        {
                            uridich_Client = clientFromDb.GetUrClient(currentClient.clientid);
                           if (uridich_Client != null)
                            {

                                MainFormCU vhod = new MainFormCU();
                                this.Hide();
                                vhod.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует");
                    }
                }
                
            }
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {
            tb_login.Text = "archive1@gmail.com";
            tb_password.Text = "US12345@";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationType reg = new RegistrationType();
            this.Hide();
            reg.ShowDialog();
        }
    }
}
