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

namespace Kursovik.Forms.Docs
{
    public partial class ChangeDocument : Form
    {
        List<document_category> categorys = new List<document_category>();
        List<privacy> privacys = new List<privacy>();
        List<type_document> types = new List<type_document>();
        List<availability> availabilities = new List<availability>();
        int id;
        Document document;
        

        public ChangeDocument(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentFromDb.DocumentChange(Convert.ToInt32(document.documentid),Convert.ToInt32(cb_type.SelectedValue), Convert.ToInt32(tb_bookshell.Text), Convert.ToInt32(tb_row.Text), Convert.ToDateTime(tb_create.Text), tb_creator.Text, tb_filepath.Text, Convert.ToInt32(cb_category.SelectedValue), Convert.ToInt32(cb_privacy.SelectedValue), Convert.ToInt32(cb_availability.SelectedValue), tb_name.Text);
            MessageBox.Show("Информация о документе обновлена");
            Documents documents = new Documents();
            this.Hide();
            documents.Show();
        }

        private void ChangeDocument_Load(object sender, EventArgs e)
        {
            //get availability
            availabilities = AvailabilityDocFromDb.getavailabilityDocs();
            cb_availability.DataSource = availabilities;
            cb_availability.DisplayMember = "name";
            cb_availability.ValueMember = "id";

            //get category
            categorys = CategoryDocFromDb.getcategoryDocs();
            cb_category.DataSource = categorys;
            cb_category.DisplayMember = "category_name";
            cb_category.ValueMember = "categoryid";

            //get privacy
            privacys = PrivacyFromDb.getprivacyDocs();

            cb_privacy.DataSource = privacys;
            cb_privacy.DisplayMember = "privacy_name";
            cb_privacy.ValueMember = "privacyid";

            //get typeDocs
            types = TypeDocFromDb.gettypeDocs();
            cb_type.DataSource = types;
            cb_type.DisplayMember = "type_name";
            cb_type.ValueMember = "typeid";


            document = DocumentFromDb.getDoc(id);
            tb_bookshell.Text = document.bookshell_number.ToString();
            tb_create.Text = document.create_datetime.ToString();
            tb_creator.Text = document.creator.ToString();
            tb_filepath.Text = document.filepath.ToString();
            tb_name.Text = document.name.ToString();
            tb_row.Text = document.row_number.ToString();
            cb_availability.Text = document.availability.ToString();
            cb_category.Text = document.category.ToString();
            if (document.privacyid == 1)
            {
                cb_privacy.Text = "Yes";
            }
            else
            {
                cb_privacy.Text = "Not";
            }
            cb_type.Text = document.type.ToString();
        }
    }
}
