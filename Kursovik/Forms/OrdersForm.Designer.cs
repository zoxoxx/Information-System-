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
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_orders
            // 
            this.dg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orders.Location = new System.Drawing.Point(12, 12);
            this.dg_orders.Name = "dg_orders";
            this.dg_orders.RowHeadersWidth = 51;
            this.dg_orders.RowTemplate.Height = 24;
            this.dg_orders.Size = new System.Drawing.Size(376, 426);
            this.dg_orders.TabIndex = 0;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_orders);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_orders;
    }
}