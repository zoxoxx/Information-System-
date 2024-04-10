namespace Kursovik.Forms
{
    partial class MagazineAutorization
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
            this.dg_magazineAutorization = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.autorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_magazineAutorization)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_magazineAutorization
            // 
            this.dg_magazineAutorization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_magazineAutorization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autorid,
            this.date_time,
            this.userid,
            this.surname,
            this.name,
            this.photo});
            this.dg_magazineAutorization.Location = new System.Drawing.Point(7, 112);
            this.dg_magazineAutorization.Name = "dg_magazineAutorization";
            this.dg_magazineAutorization.RowHeadersWidth = 51;
            this.dg_magazineAutorization.RowTemplate.Height = 24;
            this.dg_magazineAutorization.Size = new System.Drawing.Size(792, 326);
            this.dg_magazineAutorization.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(154, 44);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // autorid
            // 
            this.autorid.HeaderText = "id входа";
            this.autorid.MinimumWidth = 6;
            this.autorid.Name = "autorid";
            this.autorid.Width = 125;
            // 
            // date_time
            // 
            this.date_time.HeaderText = "дата входа";
            this.date_time.MinimumWidth = 6;
            this.date_time.Name = "date_time";
            this.date_time.Width = 125;
            // 
            // userid
            // 
            this.userid.HeaderText = "id пользователя";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // photo
            // 
            this.photo.HeaderText = "Фото";
            this.photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.photo.MinimumWidth = 6;
            this.photo.Name = "photo";
            this.photo.Width = 125;
            // 
            // MagazineAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dg_magazineAutorization);
            this.Name = "MagazineAutorization";
            this.Text = "Журнал учета авторизации";
            this.Load += new System.EventHandler(this.MagazineAutorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_magazineAutorization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_magazineAutorization;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn photo;
    }
}