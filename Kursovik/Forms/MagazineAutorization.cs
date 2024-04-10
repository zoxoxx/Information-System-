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
    public partial class MagazineAutorization : Form
    {
         List<Autorization> auto = new List<Autorization>(); 
        public MagazineAutorization()
        {
            InitializeComponent();
            dg_magazineAutorization.Columns[0].DataPropertyName = "autorid";
            dg_magazineAutorization.Columns[1].DataPropertyName = "date_time";
            dg_magazineAutorization.Columns[2].DataPropertyName = "userid";
            dg_magazineAutorization.Columns[3].DataPropertyName = "surname";
            dg_magazineAutorization.Columns[4].DataPropertyName = "name";
            dg_magazineAutorization.Columns[5].DataPropertyName = "photo";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm_Sotrudnik_ back = new MainForm_Sotrudnik_();
            this.Hide();
            back.Show();
        }

        private void MagazineAutorization_Load(object sender, EventArgs e)
        {
            auto = AutorizationMagazineFromDb.getEntrances();
            dg_magazineAutorization.DataSource = auto;
        }
    }
}
