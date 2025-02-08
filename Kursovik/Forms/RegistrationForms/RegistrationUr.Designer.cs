namespace Kursovik.Forms
{
    partial class RegistrationUr
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
            this.tb_nameCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_adressCompany = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_podPas = new System.Windows.Forms.TextBox();
            this.btn_endReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nameCompany
            // 
            this.tb_nameCompany.Location = new System.Drawing.Point(174, 58);
            this.tb_nameCompany.Name = "tb_nameCompany";
            this.tb_nameCompany.Size = new System.Drawing.Size(100, 22);
            this.tb_nameCompany.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес компании";
            // 
            // tb_adressCompany
            // 
            this.tb_adressCompany.Location = new System.Drawing.Point(174, 111);
            this.tb_adressCompany.Name = "tb_adressCompany";
            this.tb_adressCompany.Size = new System.Drawing.Size(100, 22);
            this.tb_adressCompany.TabIndex = 3;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(501, 61);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 22);
            this.tb_phone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(501, 111);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 22);
            this.tb_email.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(182, 213);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(56, 16);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Пароль";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(362, 213);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(143, 22);
            this.tb_password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Подтверждение пароля";
            // 
            // tb_podPas
            // 
            this.tb_podPas.Location = new System.Drawing.Point(362, 254);
            this.tb_podPas.Name = "tb_podPas";
            this.tb_podPas.Size = new System.Drawing.Size(143, 22);
            this.tb_podPas.TabIndex = 11;
            // 
            // btn_endReg
            // 
            this.btn_endReg.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_endReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_endReg.Location = new System.Drawing.Point(282, 337);
            this.btn_endReg.Name = "btn_endReg";
            this.btn_endReg.Size = new System.Drawing.Size(223, 51);
            this.btn_endReg.TabIndex = 12;
            this.btn_endReg.Text = "Завершить регистрацию";
            this.btn_endReg.UseVisualStyleBackColor = false;
            this.btn_endReg.Click += new System.EventHandler(this.btn_endReg_Click);
            // 
            // RegistrationUr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_endReg);
            this.Controls.Add(this.tb_podPas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_adressCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nameCompany);
            this.Name = "RegistrationUr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nameCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_adressCompany;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_podPas;
        private System.Windows.Forms.Button btn_endReg;
    }
}