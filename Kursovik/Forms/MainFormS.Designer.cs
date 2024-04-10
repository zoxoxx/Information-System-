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
            this.btn_autorisationCheck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_typeInfo = new System.Windows.Forms.GroupBox();
            this.lb_info = new System.Windows.Forms.ListBox();
            this.btn_magazineOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clients)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_typeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_clients
            // 
            this.dg_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.typeid,
            this.phone,
            this.email});
            this.dg_clients.Location = new System.Drawing.Point(54, 74);
            this.dg_clients.Name = "dg_clients";
            this.dg_clients.RowHeadersWidth = 51;
            this.dg_clients.RowTemplate.Height = 24;
            this.dg_clients.Size = new System.Drawing.Size(504, 242);
            this.dg_clients.TabIndex = 0;
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
            this.tb_search.Location = new System.Drawing.Point(175, 39);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(132, 22);
            this.tb_search.TabIndex = 2;
            // 
            // btn_restOrders
            // 
            this.btn_restOrders.Location = new System.Drawing.Point(369, 37);
            this.btn_restOrders.Name = "btn_restOrders";
            this.btn_restOrders.Size = new System.Drawing.Size(170, 31);
            this.btn_restOrders.TabIndex = 3;
            this.btn_restOrders.Text = "Реестр заказов";
            this.btn_restOrders.UseVisualStyleBackColor = true;
            this.btn_restOrders.Click += new System.EventHandler(this.btn_restOrders_Click);
            // 
            // btn_autorisationCheck
            // 
            this.btn_autorisationCheck.Location = new System.Drawing.Point(40, 398);
            this.btn_autorisationCheck.Name = "btn_autorisationCheck";
            this.btn_autorisationCheck.Size = new System.Drawing.Size(180, 40);
            this.btn_autorisationCheck.TabIndex = 4;
            this.btn_autorisationCheck.Text = "Журнал авторизации";
            this.btn_autorisationCheck.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
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
            this.gb_typeInfo.Controls.Add(this.lb_info);
            this.gb_typeInfo.Location = new System.Drawing.Point(590, 74);
            this.gb_typeInfo.Name = "gb_typeInfo";
            this.gb_typeInfo.Size = new System.Drawing.Size(200, 242);
            this.gb_typeInfo.TabIndex = 6;
            this.gb_typeInfo.TabStop = false;
            this.gb_typeInfo.Text = "groupBox1";
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
            // btn_magazineOrders
            // 
            this.btn_magazineOrders.Location = new System.Drawing.Point(12, 332);
            this.btn_magazineOrders.Name = "btn_magazineOrders";
            this.btn_magazineOrders.Size = new System.Drawing.Size(232, 36);
            this.btn_magazineOrders.TabIndex = 7;
            this.btn_magazineOrders.Text = "Журнал авторизации";
            this.btn_magazineOrders.UseVisualStyleBackColor = true;
            this.btn_magazineOrders.Click += new System.EventHandler(this.buttonAutorisation_Click);
            // 
            // MainForm_Sotrudnik_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_magazineOrders);
            this.Controls.Add(this.gb_typeInfo);
            this.Controls.Add(this.btn_autorisationCheck);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_restOrders;
        private System.Windows.Forms.Button btn_autorisationCheck;
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
        private System.Windows.Forms.Button btn_magazineOrders;
    }
}