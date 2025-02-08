namespace Kursovik.Forms.Profiles
{
    partial class ProfileSotrudnik
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
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.BackColor = System.Drawing.Color.Pink;
            this.btn_selectImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_selectImage.Location = new System.Drawing.Point(506, 151);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(98, 46);
            this.btn_selectImage.TabIndex = 1;
            this.btn_selectImage.Text = "Изменить фото";
            this.btn_selectImage.UseVisualStyleBackColor = false;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.OrangeRed;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_email.Location = new System.Drawing.Point(298, 97);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(136, 29);
            this.tb_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.OrangeRed;
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_surname.Location = new System.Drawing.Point(138, 258);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(140, 29);
            this.tb_surname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.OrangeRed;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_name.Location = new System.Drawing.Point(298, 258);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(136, 29);
            this.tb_name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.BackColor = System.Drawing.Color.OrangeRed;
            this.tb_patronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_patronymic.Location = new System.Drawing.Point(457, 258);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(132, 29);
            this.tb_patronymic.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(275, 325);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 46);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Сохранить изменения";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::Kursovik.Properties.Resources.Arrow_2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(493, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProfileSotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_patronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfileSotrudnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль сотрудника";
            this.Load += new System.EventHandler(this.ProfileSotrudnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_patronymic;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
    }
}