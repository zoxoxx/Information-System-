namespace Kursovik.Forms
{
    partial class MainForm_Sotrudnik_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_clients = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_restOrders = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_typeInfo = new System.Windows.Forms.GroupBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.ListBox();
            this.btn_documents = new System.Windows.Forms.Button();
            this.cb_type_client = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_categories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clients)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_typeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_clients
            // 
            this.dg_clients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dg_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.typeid,
            this.phone,
            this.email});
            this.dg_clients.GridColor = System.Drawing.Color.IndianRed;
            this.dg_clients.Location = new System.Drawing.Point(54, 74);
            this.dg_clients.Name = "dg_clients";
            this.dg_clients.RowHeadersWidth = 51;
            this.dg_clients.RowTemplate.Height = 24;
            this.dg_clients.Size = new System.Drawing.Size(504, 242);
            this.dg_clients.TabIndex = 0;
            this.dg_clients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_clients_CellContentDoubleClick);
            this.dg_clients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_clients_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Номер клиента";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // typeid
            // 
            this.typeid.HeaderText = "Column1";
            this.typeid.MinimumWidth = 6;
            this.typeid.Name = "typeid";
            this.typeid.Visible = false;
            this.typeid.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Электронная почта";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск клиента";
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.SystemColors.Control;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Location = new System.Drawing.Point(175, 39);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(132, 15);
            this.tb_search.TabIndex = 2;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_restOrders
            // 
            this.btn_restOrders.BackColor = System.Drawing.Color.IndianRed;
            this.btn_restOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_restOrders.Location = new System.Drawing.Point(369, 37);
            this.btn_restOrders.Name = "btn_restOrders";
            this.btn_restOrders.Size = new System.Drawing.Size(170, 31);
            this.btn_restOrders.TabIndex = 3;
            this.btn_restOrders.Text = "Реестр заказов";
            this.btn_restOrders.UseVisualStyleBackColor = false;
            this.btn_restOrders.Click += new System.EventHandler(this.btn_restOrders_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fIOToolStripMenuItem
            // 
            this.fIOToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПрофильToolStripMenuItem,
            this.выйтиИзСистемыToolStripMenuItem});
            this.fIOToolStripMenuItem.Image = global::Kursovik.Properties.Resources.profil;
            this.fIOToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fIOToolStripMenuItem.Name = "fIOToolStripMenuItem";
            this.fIOToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fIOToolStripMenuItem.Text = "FIO";
            // 
            // редактироватьПрофильToolStripMenuItem
            // 
            this.редактироватьПрофильToolStripMenuItem.Image = global::Kursovik.Properties.Resources.editProfil;
            this.редактироватьПрофильToolStripMenuItem.Name = "редактироватьПрофильToolStripMenuItem";
            this.редактироватьПрофильToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.редактироватьПрофильToolStripMenuItem.Text = "Редактировать профиль";
            this.редактироватьПрофильToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПрофильToolStripMenuItem_Click);
            // 
            // выйтиИзСистемыToolStripMenuItem
            // 
            this.выйтиИзСистемыToolStripMenuItem.Image = global::Kursovik.Properties.Resources.exit;
            this.выйтиИзСистемыToolStripMenuItem.Name = "выйтиИзСистемыToolStripMenuItem";
            this.выйтиИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.выйтиИзСистемыToolStripMenuItem.Text = "Выйти из системы";
            this.выйтиИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзСистемыToolStripMenuItem_Click);
            // 
            // gb_typeInfo
            // 
            this.gb_typeInfo.Controls.Add(this.lbl_count);
            this.gb_typeInfo.Controls.Add(this.button1);
            this.gb_typeInfo.Controls.Add(this.btn_deleteUser);
            this.gb_typeInfo.Controls.Add(this.tb_name);
            this.gb_typeInfo.Controls.Add(this.lbl_name);
            this.gb_typeInfo.Controls.Add(this.lb_info);
            this.gb_typeInfo.Location = new System.Drawing.Point(590, 74);
            this.gb_typeInfo.Name = "gb_typeInfo";
            this.gb_typeInfo.Size = new System.Drawing.Size(200, 242);
            this.gb_typeInfo.TabIndex = 6;
            this.gb_typeInfo.TabStop = false;
            this.gb_typeInfo.Text = "Информация о клиенте";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.White;
            this.lbl_count.Location = new System.Drawing.Point(21, 77);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(31, 16);
            this.lbl_count.TabIndex = 5;
            this.lbl_count.Text = "aaa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(59, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.White;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteUser.Location = new System.Drawing.Point(59, 174);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(100, 25);
            this.btn_deleteUser.TabIndex = 3;
            this.btn_deleteUser.Text = "Удалить";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(59, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(114, 22);
            this.tb_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(19, 46);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(33, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Имя";
            // 
            // lb_info
            // 
            this.lb_info.FormattingEnabled = true;
            this.lb_info.ItemHeight = 16;
            this.lb_info.Location = new System.Drawing.Point(7, 22);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(187, 212);
            this.lb_info.TabIndex = 0;
            // 
            // btn_documents
            // 
            this.btn_documents.BackColor = System.Drawing.Color.IndianRed;
            this.btn_documents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_documents.Location = new System.Drawing.Point(216, 327);
            this.btn_documents.Name = "btn_documents";
            this.btn_documents.Size = new System.Drawing.Size(170, 36);
            this.btn_documents.TabIndex = 8;
            this.btn_documents.Text = "Документы";
            this.btn_documents.UseVisualStyleBackColor = false;
            this.btn_documents.Click += new System.EventHandler(this.btn_documents_Click);
            // 
            // cb_type_client
            // 
            this.cb_type_client.BackColor = System.Drawing.SystemColors.Highlight;
            this.cb_type_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_type_client.FormattingEnabled = true;
            this.cb_type_client.Location = new System.Drawing.Point(628, 37);
            this.cb_type_client.Name = "cb_type_client";
            this.cb_type_client.Size = new System.Drawing.Size(121, 24);
            this.cb_type_client.TabIndex = 9;
            this.cb_type_client.SelectedIndexChanged += new System.EventHandler(this.cb_type_client_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Клиент";
            // 
            // btn_categories
            // 
            this.btn_categories.BackColor = System.Drawing.Color.Firebrick;
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_categories.Location = new System.Drawing.Point(628, 327);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Size = new System.Drawing.Size(135, 36);
            this.btn_categories.TabIndex = 11;
            this.btn_categories.Text = "Категории";
            this.btn_categories.UseVisualStyleBackColor = false;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // MainForm_Sotrudnik_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_type_client);
            this.Controls.Add(this.btn_documents);
            this.Controls.Add(this.gb_typeInfo);
            this.Controls.Add(this.btn_restOrders);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_clients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm_Sotrudnik_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр клиентов";
            this.Load += new System.EventHandler(this.MainForm_Sotrudnik__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_clients)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_typeInfo.ResumeLayout(false);
            this.gb_typeInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_restOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_typeInfo;
        private System.Windows.Forms.ListBox lb_info;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзСистемыToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btn_documents;
        private System.Windows.Forms.ComboBox cb_type_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_count;
    }
}