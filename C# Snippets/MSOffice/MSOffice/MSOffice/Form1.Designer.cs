namespace MSOffice {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_word = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(43, 67);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(75, 23);
            this.btn_excel.TabIndex = 0;
            this.btn_excel.Text = "Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_word
            // 
            this.btn_word.Location = new System.Drawing.Point(203, 67);
            this.btn_word.Name = "btn_word";
            this.btn_word.Size = new System.Drawing.Size(75, 23);
            this.btn_word.TabIndex = 1;
            this.btn_word.Text = "Word";
            this.btn_word.UseVisualStyleBackColor = true;
            this.btn_word.Click += new System.EventHandler(this.btn_word_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 148);
            this.Controls.Add(this.btn_word);
            this.Controls.Add(this.btn_excel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_word;
    }
}

