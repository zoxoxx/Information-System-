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

namespace Kursovik.Forms.Orders
{
    public partial class AddOrderForm : Form
    {
        public static List<Document> documents = new List<Document>();
        public static int valueid;
        public AddOrderForm()
        {
            InitializeComponent();
            dg_orders.Columns[6].DataPropertyName = "documentid";
            dg_orders.Columns[7].DataPropertyName = "type";
            dg_orders.Columns[4].DataPropertyName = "bookshell_number";
            dg_orders.Columns[5].DataPropertyName = "row_number";
            dg_orders.Columns[10].DataPropertyName = "create_datetime";
            dg_orders.Columns[1].DataPropertyName = "creator";
            dg_orders.Columns[8].DataPropertyName = "filepath";
            dg_orders.Columns[2].DataPropertyName = "category";
            dg_orders.Columns[9].DataPropertyName = "privacyid";
            dg_orders.Columns[3].DataPropertyName = "availability";
            dg_orders.Columns[0].DataPropertyName = "name";
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            documents = DocumentFromDb.getPublicDocs();
            dg_orders.DataSource = documents;
        }

        private void dg_orders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            valueid = dg_orders.CurrentRow.Index;
            OrderFromDb.OrderAdd(MainForm_Sotrudnik_.clients[MainForm_Sotrudnik_.valueid].clientid, Authorisation.currentUser.userid, DateTime.Now, 1, documents[valueid].documentid);
            MainForm_Sotrudnik_ mainForm_Sotrudnik_ = new MainForm_Sotrudnik_();
            this.Hide();
            mainForm_Sotrudnik_.Show();
        }
    }
}
