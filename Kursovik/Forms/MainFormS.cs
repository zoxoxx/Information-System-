using Kursovik.Classes;
using Kursovik.Forms.Categorys;
using Kursovik.Forms.Docs;
using Kursovik.Forms.Orders;
using Kursovik.Forms.Profiles;
using Kursovik.Model;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.Forms
{
    public partial class MainForm_Sotrudnik_ : Form
    {
        List <typeClient> types = new List <typeClient> ();
        public static string loginCurrent;
        private static int Counters = 0;
        public static List<Client> clients = new List<Client>();
        ClientFromDb clientFromDb = new ClientFromDb();
       public static int valueid;

        //region dg logic
        public static Client currentClient { get; set; } = null;
        public static Physical_Client physical_Client { get; set; } = null;
        public static Uridich_Client uridich_Client { get; set; } = null;
        public MainForm_Sotrudnik_()
        {
            InitializeComponent();
            dg_clients.Columns[0].DataPropertyName = "clientid";
            dg_clients.Columns[1].DataPropertyName = "typeid";
            dg_clients.Columns[2].DataPropertyName = "phone";
            dg_clients.Columns[3].DataPropertyName = "email";
        }

        private void MainForm_Sotrudnik__Load(object sender, EventArgs e)
        {
            gb_typeInfo.Visible = false;
           
            fIOToolStripMenuItem.Text = Authorisation.currentUser.surname + Authorisation.currentUser.name;
            ViewAllClients();
            //get types
            types = TypeClientFromDb.getAlltypes();
            types.Insert(0, new typeClient(0, "All"));
            cb_type_client.DataSource = types;
            cb_type_client.DisplayMember = "type_name";
            cb_type_client.ValueMember = "typeid";
        }

        private void ViewAllClients()
        {
            clients = clientFromDb.getAllClients();
            dg_clients.DataSource = clients;
        }

        private void выйтиИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            this.Close();
            authorisation.Show();
        }

        private void dg_clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            valueid = dg_clients.CurrentRow.Index;

            gb_typeInfo.Visible = true;
            physical_Client = clientFromDb.GetPhysClient(clients[valueid].clientid);
            if (physical_Client != null)
            {
                tb_name.Text = physical_Client.surname + " " + physical_Client.name;
            }
            else
            {
                uridich_Client = clientFromDb.GetUrClient(clients[valueid].clientid);
                if (uridich_Client != null)
                {
                    tb_name.Text = uridich_Client.name_company;
                }
            }
            int counterOrders = OrderFromDb.GetCounterOrders(clients[valueid].clientid);
            lbl_count.Text = "Количество заказов: " + counterOrders;
        }

        private void btn_restOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            this.Hide();
            ordersForm.Show();
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileSotrudnik profile = new ProfileSotrudnik();
            this.Hide();
            profile.Show();
        }

        private void btn_documents_Click(object sender, EventArgs e)
        {
            Documents documents = new Documents();
            this.Hide();
            documents.Show();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dg_clients.DataSource = SearchClients(tb_search.Text);
        }

        private List<Client> SearchClients(string txbSearch)
        {
            List<Client> clientSearch = new List<Client>();

            foreach (Client item in clients)
            {
                if (item.email.StartsWith(txbSearch) || item.phone.StartsWith(txbSearch) || item.email.EndsWith(txbSearch) || item.email.Contains(txbSearch))
                {
                    clientSearch.Add(item);
                }
            }
            return clientSearch;
        }

        private void cb_type_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type_client.SelectedIndex == 0) 
            {
                ViewAllClients();
            }
            else
            {
                clients.Clear();
                clients = TypeClientFromDb.FiltrClientsByType(Convert.ToInt32(cb_type_client.SelectedValue));
                dg_clients.DataSource = clients;
            }
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            Choice_category choice_Category = new Choice_category();
            this.Hide();
            choice_Category.Show();
        }

        private void dg_clients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            ClientFromDb.ClientDelete(clients[valueid].clientid);
            MessageBox.Show(clients[valueid].clientid.ToString());
            ViewAllClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            this.Hide();
            addOrderForm.Show();
        }
    }
}
