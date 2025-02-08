namespace Kursovik.Forms.Categorys
{
    partial class Choice_category
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
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_changeCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.Brown;
            this.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addCategory.Location = new System.Drawing.Point(531, 100);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(143, 302);
            this.btn_addCategory.TabIndex = 0;
            this.btn_addCategory.Text = "Добавить";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_changeCategory
            // 
            this.btn_changeCategory.BackColor = System.Drawing.Color.Firebrick;
            this.btn_changeCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changeCategory.Location = new System.Drawing.Point(141, 100);
            this.btn_changeCategory.Name = "btn_changeCategory";
            this.btn_changeCategory.Size = new System.Drawing.Size(143, 302);
            this.btn_changeCategory.TabIndex = 1;
            this.btn_changeCategory.Text = "Изменить";
            this.btn_changeCategory.UseVisualStyleBackColor = false;
            this.btn_changeCategory.Click += new System.EventHandler(this.btn_changeCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Что необходимо?";
            // 
            // Choice_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_changeCategory);
            this.Controls.Add(this.btn_addCategory);
            this.Name = "Choice_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор действия";
            this.Load += new System.EventHandler(this.Choice_category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_changeCategory;
        private System.Windows.Forms.Label label1;
    }
}