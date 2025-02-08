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
    public partial class Documents : Form
    {
        List<document_category> categorys = new List<document_category>();
        List<privacy> privacys = new List<privacy>();
        List<type_document> types = new List<type_document>();
        List<availability> availabilities = new List<availability>();
        List<Panel> panels = new List<Panel>();
        List<Document> documents = new List<Document>();
        List<Document> changedocuments = new List<Document>();
        int index;
        public Documents()
        {
            InitializeComponent();
            //del
            dg_docsFromDel.Columns[0].DataPropertyName = "documentid";
            dg_docsFromDel.Columns[1].DataPropertyName = "type";
            dg_docsFromDel.Columns[2].DataPropertyName = "bookshell_number";
            dg_docsFromDel.Columns[3].DataPropertyName = "row_number";
            dg_docsFromDel.Columns[4].DataPropertyName = "create_datetime";
            dg_docsFromDel.Columns[5].DataPropertyName = "creator";
            dg_docsFromDel.Columns[6].DataPropertyName = "filepath";
            dg_docsFromDel.Columns[7].DataPropertyName = "category";
            dg_docsFromDel.Columns[8].DataPropertyName = "privacyid";
            dg_docsFromDel.Columns[9].DataPropertyName = "availability";
            dg_docsFromDel.Columns[10].DataPropertyName = "name";
            //change
            dg_changeDoc.Columns[0].DataPropertyName = "documentid";
            dg_changeDoc.Columns[1].DataPropertyName = "type";
            dg_changeDoc.Columns[2].DataPropertyName = "bookshell_number";
            dg_changeDoc.Columns[3].DataPropertyName = "row_number";
            dg_changeDoc.Columns[4].DataPropertyName = "create_datetime";
            dg_changeDoc.Columns[5].DataPropertyName = "creator";
            dg_changeDoc.Columns[6].DataPropertyName = "filepath";
            dg_changeDoc.Columns[7].DataPropertyName = "category";
            dg_changeDoc.Columns[8].DataPropertyName = "privacyid";
            dg_changeDoc.Columns[9].DataPropertyName = "availability";
            dg_changeDoc.Columns[10].DataPropertyName = "name";
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            //get change
            loadChange();
            //get del
            loadDocuments();

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);

            panels[index].BringToFront();
            panels[index].Visible = true;

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

        }

        private void loadDocuments()
        {
            documents = DocumentFromDb.getAllDocs();
            dg_docsFromDel.DataSource = documents;
            
        }

        private void loadChange()
        {
            changedocuments = DocumentFromDb.getAllDocs();
            dg_changeDoc.DataSource = changedocuments;
        }
        private void btn_addDoc_Click(object sender, EventArgs e)
        {
            DocumentFromDb.DocumentAdd(Convert.ToInt32(cb_type.SelectedValue), Convert.ToInt32(tb_bookshell.Text), Convert.ToInt32(tb_row.Text), Convert.ToDateTime(tb_create.Text), tb_creator.Text, tb_filepath.Text, Convert.ToInt32(cb_category.SelectedValue), Convert.ToInt32(cb_privacy.SelectedValue), Convert.ToInt32(cb_availability.SelectedValue), tb_name.Text);
        }

        private void btn_editDocs_Click(object sender, EventArgs e)
        {
            if (index<panels.Count-1)
            {
                
                panels[++index].BringToFront();
                panels[index].Visible = true;
            }
            if (panel3.Visible == true)
            {
                loadDocuments();
            }
        }

        private void btn_pred_Click(object sender, EventArgs e)
        {
            
            if (index>0)
            {
                panels[index].Visible = false;
                panels[--index].BringToFront();
                panels[index].Visible = true;
            }
            if (panel3.Visible == true)
            {
                loadDocuments();
            }
        }

        private void dg_docsFromDel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int id = Convert.ToInt32(dg_docsFromDel.Rows[e.RowIndex].Cells[0].Value); 

                DialogResult result = MessageBox.Show("Удалить элемент с id " + id + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                   DocumentFromDb.DeleteDocument(id);
                    loadDocuments();
                }
            }
        }

        private void dg_changeDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dg_changeDoc.Rows[e.RowIndex].Cells[0].Value);

                DialogResult result = MessageBox.Show("Изменить элемент с id " + id + "?", "Подтверждение обновления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ChangeDocument changeDocument = new ChangeDocument(id);
                    this.Hide();
                    changeDocument.Show();  
                }
            }
    }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm_Sotrudnik_ mainForm = new MainForm_Sotrudnik_();
            this.Hide();
            mainForm.Show();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
