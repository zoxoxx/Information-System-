﻿namespace Kursovik.Forms
{
    partial class MainFormCU
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
            this.dg_urdoc = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.dg_urdoc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_urdoc
            // 
            this.dg_urdoc.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dg_urdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_urdoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dg_urdoc.GridColor = System.Drawing.Color.Firebrick;
            this.dg_urdoc.Location = new System.Drawing.Point(0, 113);
            this.dg_urdoc.Name = "dg_urdoc";
            this.dg_urdoc.RowHeadersWidth = 51;
            this.dg_urdoc.RowTemplate.Height = 24;
            this.dg_urdoc.Size = new System.Drawing.Size(800, 265);
            this.dg_urdoc.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
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
            this.выйтиИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзСистемыToolStripMenuItem_Click_1);
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
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
            this.bookshell.Width = 70;
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
            this.documentid.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
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
            this.create.Width = 125;
            // 
            // MainFormCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dg_urdoc);
            this.Name = "MainFormCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма юридического лица";
            this.Load += new System.EventHandler(this.MainFormCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_urdoc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_urdoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзСистемыToolStripMenuItem;
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