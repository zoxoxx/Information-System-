namespace Kursovik.Forms
{
    partial class OrdersForm
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_get = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_orders
            // 
            this.dg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userid,
            this.date_get,
            this.status,
            this.doc,
            this.useridd});
            this.dg_orders.Location = new System.Drawing.Point(12, 12);
            this.dg_orders.Name = "dg_orders";
            this.dg_orders.RowHeadersWidth = 51;
            this.dg_orders.RowTemplate.Height = 24;
            this.dg_orders.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dg_orders.Size = new System.Drawing.Size(499, 426);
            this.dg_orders.TabIndex = 0;
            this.dg_orders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_orders_CellDoubleClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(592, 116);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Заказ принят";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(592, 197);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "В процессе ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(592, 285);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Выполнен";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Номер заказа";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // userid
            // 
            this.userid.HeaderText = "Номер клиента";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.Width = 90;
            // 
            // date_get
            // 
            this.date_get.HeaderText = "Дата создания";
            this.date_get.MinimumWidth = 6;
            this.date_get.Name = "date_get";
            this.date_get.Width = 90;
            // 
            // status
            // 
            this.status.HeaderText = "Статус заказа";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 90;
            // 
            // doc
            // 
            this.doc.HeaderText = "Документ";
            this.doc.MinimumWidth = 6;
            this.doc.Name = "doc";
            this.doc.Visible = false;
            this.doc.Width = 125;
            // 
            // useridd
            // 
            this.useridd.HeaderText = "id";
            this.useridd.MinimumWidth = 6;
            this.useridd.Name = "useridd";
            this.useridd.Visible = false;
            this.useridd.Width = 125;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dg_orders);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_orders;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_get;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridd;
    }
}