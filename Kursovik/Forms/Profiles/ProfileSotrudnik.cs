using Kursovik.Model;
using NAudio.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Kursovik.Forms.Profiles
{
    public partial class ProfileSotrudnik : Form
    {
        UserFromDb userFromDb = new UserFromDb();
        string osnovaPath = "..\\..\\Images\\";
        string exactPath;
        bool checkCnangePhoto = false;
        public ProfileSotrudnik()
        {
            InitializeComponent();
        }

        private void ProfileSotrudnik_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(Authorisation.currentUser.photo);
            pictureBox1.Image = image; ;
            tb_email.Text = Authorisation.currentUser.email;
            tb_name.Text = Authorisation.currentUser.name;
            tb_surname.Text = Authorisation.currentUser.surname;
            tb_patronymic.Text = Authorisation.currentUser.patronymic;
        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;

                string imageName = Path.GetFileName(imagePath);
                string full = Path.GetFullPath(osnovaPath);
                 exactPath = Path.Combine(full, Authorisation.currentUser.userid.ToString()+".jpg");
                imagePath = Path.GetFullPath(imagePath);
                MessageBox.Show(full);
                MessageBox.Show(exactPath);

                File.Copy(imagePath, exactPath, true);
            }
            checkCnangePhoto = true;



        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (checkCnangePhoto == true)
            {
            string name = Path.GetFileName(exactPath);
            string photo = "..\\..\\Images\\" + name;
            MessageBox.Show(photo);
            UserFromDb.updateUser(Authorisation.currentUser.userid, tb_email.Text, photo, tb_surname.Text, tb_name.Text, tb_patronymic.Text);
            }
            else
            {
                UserFromDb.updateUser(Authorisation.currentUser.userid, tb_email.Text, Authorisation.currentUser.photo, tb_surname.Text, tb_name.Text, tb_patronymic.Text);
            }
                Authorisation.currentUser = userFromDb.UpdateInfo(Authorisation.currentUser.userid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm_Sotrudnik_ back = new MainForm_Sotrudnik_();
            this.Hide();
            back.Show();
        }
    }
}
