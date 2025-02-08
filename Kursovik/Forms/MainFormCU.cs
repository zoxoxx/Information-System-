using Kursovik.Classes;
using Kursovik.Forms.Profiles;
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
    public partial class MainFormCU : Form
    {
        public List<Document> documents = new List<Document>();
        public MainFormCU()
        {
            InitializeComponent();
            dg_urdoc.Columns[6].DataPropertyName = "documentid";
            dg_urdoc.Columns[7].DataPropertyName = "type";
            dg_urdoc.Columns[4].DataPropertyName = "bookshell_number";
            dg_urdoc.Columns[5].DataPropertyName = "row_number";
            dg_urdoc.Columns[10].DataPropertyName = "create_datetime";
            dg_urdoc.Columns[1].DataPropertyName = "creator";
            dg_urdoc.Columns[8].DataPropertyName = "filepath";
            dg_urdoc.Columns[2].DataPropertyName = "category";
            dg_urdoc.Columns[9].DataPropertyName = "privacyid";
            dg_urdoc.Columns[3].DataPropertyName = "availability";
            dg_urdoc.Columns[0].DataPropertyName = "name";
        }


        private void выйтиИзСистемыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            this.Close();
            authorisation.Show();
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileUC profile = new ProfileUC();
            this.Hide();
            profile.Show();
        }

        private void MainFormCP_Load(object sender, EventArgs e)
        {
            fIOToolStripMenuItem.Text = Authorisation.uridich_Client.name_company;
            ViewAllDocuments();
        }

        private void ViewAllDocuments()
        {
           documents = DocumentFromDb.getPrivacyDocs();
            dg_urdoc.DataSource = documents;
        }
    }
}
