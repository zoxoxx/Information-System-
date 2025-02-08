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
    public partial class OrdersForm : Form
    {
        List<Order> orders = new List<Order>();
        public OrdersForm()
        {
            InitializeComponent();
            dg_orders.Columns[0].DataPropertyName = "getid";
            dg_orders.Columns[1].DataPropertyName = "clientid";
            dg_orders.Columns[2].DataPropertyName = "date_get";
            dg_orders.Columns[3].DataPropertyName = "statusid";
            dg_orders.Columns[4].DataPropertyName = "documentid";
            dg_orders.Columns[5].DataPropertyName = "userid";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void dg_orders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            orders = OrderFromDb.GetOrders();
            dg_orders.DataSource = orders;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
