namespace Personalverwaltung {
    partial class Personalliste {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lv_ausgabe = new System.Windows.Forms.ListView();
            this.lbl_ausgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_ausgabe
            // 
            this.lv_ausgabe.Location = new System.Drawing.Point(12, 12);
            this.lv_ausgabe.Name = "lv_ausgabe";
            this.lv_ausgabe.Size = new System.Drawing.Size(418, 254);
            this.lv_ausgabe.TabIndex = 16;
            this.lv_ausgabe.UseCompatibleStateImageBehavior = false;
            this.lv_ausgabe.View = System.Windows.Forms.View.Details;
            // 
            // lbl_ausgabe
            // 
            this.lbl_ausgabe.AutoSize = true;
            this.lbl_ausgabe.Location = new System.Drawing.Point(12, 287);
            this.lbl_ausgabe.Name = "lbl_ausgabe";
            this.lbl_ausgabe.Size = new System.Drawing.Size(49, 13);
            this.lbl_ausgabe.TabIndex = 14;
            this.lbl_ausgabe.Text = "Ausgabe";
            // 
            // Personalliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 426);
            this.Controls.Add(this.lv_ausgabe);
            this.Controls.Add(this.lbl_ausgabe);
            this.Name = "Personalliste";
            this.Text = "Personalliste";
            this.Load += new System.EventHandler(this.Personalliste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_ausgabe;
        private System.Windows.Forms.Label lbl_ausgabe;
    }
}