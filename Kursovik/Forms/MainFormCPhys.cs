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
    public partial class MainFormCPhys : Form
    {
        public List<Document> documents = new List<Document>();
        List<document_category> categorys = new List<document_category>();
        List<availability> availabilities = new List<availability>();
        bool categoryUse = false;
        bool availabilityUse = false;
        public MainFormCPhys()
        {
            InitializeComponent();
            dg_physdoc.Columns[6].DataPropertyName = "documentid";
            dg_physdoc.Columns[7].DataPropertyName = "type";
            dg_physdoc.Columns[4].DataPropertyName = "bookshell_number";
            dg_physdoc.Columns[5].DataPropertyName = "row_number";
            dg_physdoc.Columns[10].DataPropertyName = "create_datetime";
            dg_physdoc.Columns[1].DataPropertyName = "creator";
            dg_physdoc.Columns[8].DataPropertyName = "filepath";
            dg_physdoc.Columns[2].DataPropertyName = "category";
            dg_physdoc.Columns[9].DataPropertyName = "privacyid";
            dg_physdoc.Columns[3].DataPropertyName = "availability";
            dg_physdoc.Columns[0].DataPropertyName = "name";
        }

        private void MainFormCU_Load(object sender, EventArgs e)
        {
            fIOToolStripMenuItem.Text = Authorisation.physical_Client.surname + Authorisation.physical_Client.name;
            ViewAllDocuments();
            //get category
            categorys = CategoryDocFromDb.getcategoryDocs();
            categorys.Insert(0, new document_category(0, "all", "allll"));
            cmb_category.DataSource = categorys;
            cmb_category.DisplayMember = "category_name";
            cmb_category.ValueMember = "categoryid";
            //get availability
            availabilities = AvailabilityDocFromDb.getavailabilityDocs();
            availabilities.Insert(0, new availability(0, "skip"));
            cmb_availability.DataSource = availabilities;
            cmb_availability.DisplayMember = "name";
            cmb_availability.ValueMember = "id";
        }

        private void выйтиИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            this.Close();
            authorisation.Show();
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilePC profile = new ProfilePC();
            this.Hide();
            profile.Show();
        }
        private void ViewAllDocuments()
        {
            documents = DocumentFromDb.getPublicDocs();
            dg_physdoc.DataSource = documents;
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cmb_category.SelectedIndex == 0 && availabilityUse == false)
            {
                categoryUse = false;
                ViewAllDocuments();
            }
            else if (cmb_category.SelectedIndex > 0 && availabilityUse == true)
            {
                categoryUse = true;
                documents = TypeDocFromDb.FiltrDocsByCategoryAndAvail(Convert.ToInt32(cmb_category.SelectedValue), Convert.ToInt32(cmb_availability.SelectedValue));
                dg_physdoc.DataSource = documents;
            }
            else if (cmb_category.SelectedIndex > 0 && availabilityUse == false)
            {
                categoryUse = true;
                documents = TypeDocFromDb.FiltrDocsByCategory(Convert.ToInt32(cmb_category.SelectedValue));
                dg_physdoc.DataSource = documents;
            }
        }
        private void cmb_availability_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cmb_availability.SelectedIndex == 0 && categoryUse == false)
            {
                availabilityUse = false;
                ViewAllDocuments();
            }
            else if (cmb_availability.SelectedIndex > 0 && categoryUse == false)
            {
                availabilityUse = true;
                documents = TypeDocFromDb.FiltrDocsByAvailability(Convert.ToInt32(cmb_availability.SelectedValue));
                dg_physdoc.DataSource = documents;
            }
            else if (cmb_availability.SelectedIndex > 0 && categoryUse == true)
            {
                availabilityUse = true;
                documents = TypeDocFromDb.FiltrDocsByCategoryAndAvail(Convert.ToInt32(cmb_category.SelectedValue), Convert.ToInt32(cmb_availability.SelectedValue));
                dg_physdoc.DataSource = documents;
            }
        }
      



        private void txbsearch_TextChanged(object sender, EventArgs e)
        {
            dg_physdoc.DataSource = SearchDocuments(txbsearch.Text);
        }

        private List<Document> SearchDocuments(string txbSearch)
        {
            List<Document> documentSearch = new List<Document>();

            foreach (Document item in documents)
            {
                if (item.name.StartsWith(txbSearch) || item.name.EndsWith(txbSearch))
                {
                    documentSearch.Add(item);
                }
            }
            return documentSearch;
        }


    }
}
