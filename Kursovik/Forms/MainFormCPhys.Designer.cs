namespace Kursovik.Forms
{
    partial class MainFormCPhys
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
            this.dg_physdoc = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_availability = new System.Windows.Forms.ComboBox();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookshell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_physdoc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_physdoc
            // 
            this.dg_physdoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_physdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_physdoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.creator,
            this.category,
            this.availability,
            this.bookshell,
            this.row,
            this.documentid,
            this.type,
            this.filepath,
            this.privacy,
            this.create});
            this.dg_physdoc.Location = new System.Drawing.Point(-1, 113);
            this.dg_physdoc.Name = "dg_physdoc";
            this.dg_physdoc.RowHeadersWidth = 51;
            this.dg_physdoc.RowTemplate.Height = 24;
            this.dg_physdoc.Size = new System.Drawing.Size(800, 265);
            this.dg_physdoc.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
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
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(86, 76);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 24);
            this.cmb_category.TabIndex = 8;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // cmb_availability
            // 
            this.cmb_availability.FormattingEnabled = true;
            this.cmb_availability.Location = new System.Drawing.Point(317, 77);
            this.cmb_availability.Name = "cmb_availability";
            this.cmb_availability.Size = new System.Drawing.Size(121, 24);
            this.cmb_availability.TabIndex = 9;
            this.cmb_availability.SelectedIndexChanged += new System.EventHandler(this.cmb_availability_SelectedIndexChanged);
            // 
            // txbsearch
            // 
            this.txbsearch.Location = new System.Drawing.Point(588, 78);
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(184, 22);
            this.txbsearch.TabIndex = 10;
            this.txbsearch.TextChanged += new System.EventHandler(this.txbsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наличие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск";
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 110;
            // 
            // creator
            // 
            this.creator.HeaderText = "Автор";
            this.creator.MinimumWidth = 6;
            this.creator.Name = "creator";
            this.creator.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "Категория";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Width = 125;
            // 
            // availability
            // 
            this.availability.HeaderText = "Наличие";
            this.availability.MinimumWidth = 6;
            this.availability.Name = "availability";
            this.availability.Width = 75;
            // 
            // bookshell
            // 
            this.bookshell.HeaderText = "Полка";
            this.bookshell.MinimumWidth = 6;
            this.bookshell.Name = "bookshell";
            this.bookshell.Width = 50;
            // 
            // row
            // 
            this.row.HeaderText = "Строчка";
            this.row.MinimumWidth = 6;
            this.row.Name = "row";
            this.row.Width = 75;
            // 
            // documentid
            // 
            this.documentid.HeaderText = "Column1";
            this.documentid.MinimumWidth = 6;
            this.documentid.Name = "documentid";
            this.documentid.Visible = false;
            this.documentid.Width = 10;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 95;
            // 
            // filepath
            // 
            this.filepath.HeaderText = "Путь";
            this.filepath.MinimumWidth = 6;
            this.filepath.Name = "filepath";
            this.filepath.Visible = false;
            this.filepath.Width = 125;
            // 
            // privacy
            // 
            this.privacy.HeaderText = "Приватность";
            this.privacy.MinimumWidth = 6;
            this.privacy.Name = "privacy";
            this.privacy.Visible = false;
            this.privacy.Width = 125;
            // 
            // create
            // 
            this.create.HeaderText = "Дата создания";
            this.create.MinimumWidth = 6;
            this.create.Name = "create";
            this.create.Width = 90;
            // 
            // MainFormCPhys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbsearch);
            this.Controls.Add(this.cmb_availability);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dg_physdoc);
            this.Name = "MainFormCPhys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма физического клиента";
            this.Load += new System.EventHandler(this.MainFormCU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_physdoc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_physdoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзСистемыToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_availability;
        private System.Windows.Forms.TextBox txbsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookshell;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn create;
    }
}