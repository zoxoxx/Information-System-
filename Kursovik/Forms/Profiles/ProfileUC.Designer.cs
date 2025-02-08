namespace Kursovik.Forms.Profiles
{
    partial class ProfileUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nameCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.lbl_profile_name = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(113, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название компании";
            // 
            // tb_nameCompany
            // 
            this.tb_nameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_nameCompany.Location = new System.Drawing.Point(174, 222);
            this.tb_nameCompany.Name = "tb_nameCompany";
            this.tb_nameCompany.Size = new System.Drawing.Size(137, 36);
            this.tb_nameCompany.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(507, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // tb_adress
            // 
            this.tb_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_adress.Location = new System.Drawing.Point(490, 222);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(120, 36);
            this.tb_adress.TabIndex = 3;
            // 
            // lbl_profile_name
            // 
            this.lbl_profile_name.AutoSize = true;
            this.lbl_profile_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_profile_name.Location = new System.Drawing.Point(181, 30);
            this.lbl_profile_name.Name = "lbl_profile_name";
            this.lbl_profile_name.Size = new System.Drawing.Size(265, 39);
            this.lbl_profile_name.TabIndex = 4;
            this.lbl_profile_name.Text = "Ваш профиль - ";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(314, 324);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 54);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Сохранить изменения";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Location = new System.Drawing.Point(13, 404);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 34);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ProfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_profile_name);
            this.Controls.Add(this.tb_adress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nameCompany);
            this.Controls.Add(this.label1);
            this.Name = "ProfileUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.ProfileUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nameCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Label lbl_profile_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
    }
}