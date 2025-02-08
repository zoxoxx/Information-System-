namespace Kursovik.Forms.Orders
{
    partial class AddOrderForm
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
            this.dg_orders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_orders
            // 
            this.dg_orders.BackgroundColor = System.Drawing.Color.White;
            this.dg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dg_orders.GridColor = System.Drawing.Color.White;
            this.dg_orders.Location = new System.Drawing.Point(33, 94);
            this.dg_orders.Name = "dg_orders";
            this.dg_orders.RowHeadersWidth = 51;
            this.dg_orders.RowTemplate.Height = 24;
            this.dg_orders.Size = new System.Drawing.Size(842, 265);
            this.dg_orders.TabIndex = 1;
            this.dg_orders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_orders_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(859, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите документ который необходимо добавить в заказ";
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // creator
            // 
            this.creator.HeaderText = "Автор";
            this.creator.MinimumWidth = 6;
            this.creator.Name = "creator";
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
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_orders);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_orders;
        private System.Windows.Forms.Label label1;
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