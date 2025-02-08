namespace Kursovik.Forms
{
    partial class RegistrationType
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
            this.btn_physReg = new System.Windows.Forms.Button();
            this.btn_urReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_physReg
            // 
            this.btn_physReg.BackColor = System.Drawing.Color.Maroon;
            this.btn_physReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_physReg.Location = new System.Drawing.Point(52, 138);
            this.btn_physReg.Name = "btn_physReg";
            this.btn_physReg.Size = new System.Drawing.Size(122, 53);
            this.btn_physReg.TabIndex = 0;
            this.btn_physReg.Text = "Физическое лицо";
            this.btn_physReg.UseVisualStyleBackColor = false;
            this.btn_physReg.Click += new System.EventHandler(this.btn_physReg_Click);
            // 
            // btn_urReg
            // 
            this.btn_urReg.BackColor = System.Drawing.Color.DarkRed;
            this.btn_urReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urReg.Location = new System.Drawing.Point(312, 138);
            this.btn_urReg.Name = "btn_urReg";
            this.btn_urReg.Size = new System.Drawing.Size(122, 53);
            this.btn_urReg.TabIndex = 1;
            this.btn_urReg.Text = "Юридическое лицо";
            this.btn_urReg.UseVisualStyleBackColor = false;
            this.btn_urReg.Click += new System.EventHandler(this.btn_urReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите тип регистрации";
            // 
            // RegistrationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(525, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_urReg);
            this.Controls.Add(this.btn_physReg);
            this.Name = "RegistrationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор регистрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_physReg;
        private System.Windows.Forms.Button btn_urReg;
        private System.Windows.Forms.Label label1;
    }
}