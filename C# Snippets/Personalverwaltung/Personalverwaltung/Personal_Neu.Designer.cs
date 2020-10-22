namespace Personalverwaltung {
    partial class Personal_Neu {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_personalnr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.rb_arbeiter = new System.Windows.Forms.RadioButton();
            this.tb_gehalt_lohn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_angestellte = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Personalnr.";
            // 
            // tb_personalnr
            // 
            this.tb_personalnr.Location = new System.Drawing.Point(116, 36);
            this.tb_personalnr.Name = "tb_personalnr";
            this.tb_personalnr.Size = new System.Drawing.Size(132, 20);
            this.tb_personalnr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vorname";
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(116, 77);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(132, 20);
            this.tb_vorname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nachname";
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(116, 270);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_speichern.TabIndex = 7;
            this.btn_speichern.Text = "speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(116, 117);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(132, 20);
            this.tb_nachname.TabIndex = 3;
            // 
            // rb_arbeiter
            // 
            this.rb_arbeiter.AutoSize = true;
            this.rb_arbeiter.Location = new System.Drawing.Point(207, 189);
            this.rb_arbeiter.Name = "rb_arbeiter";
            this.rb_arbeiter.Size = new System.Drawing.Size(61, 17);
            this.rb_arbeiter.TabIndex = 5;
            this.rb_arbeiter.Text = "Arbeiter";
            this.rb_arbeiter.UseVisualStyleBackColor = true;
            // 
            // tb_gehalt_lohn
            // 
            this.tb_gehalt_lohn.Location = new System.Drawing.Point(116, 212);
            this.tb_gehalt_lohn.Name = "tb_gehalt_lohn";
            this.tb_gehalt_lohn.Size = new System.Drawing.Size(132, 20);
            this.tb_gehalt_lohn.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gehalt/StdLohn";
            // 
            // rb_angestellte
            // 
            this.rb_angestellte.AutoSize = true;
            this.rb_angestellte.Checked = true;
            this.rb_angestellte.Location = new System.Drawing.Point(116, 189);
            this.rb_angestellte.Name = "rb_angestellte";
            this.rb_angestellte.Size = new System.Drawing.Size(80, 17);
            this.rb_angestellte.TabIndex = 4;
            this.rb_angestellte.TabStop = true;
            this.rb_angestellte.Text = "Angestellter";
            this.rb_angestellte.UseVisualStyleBackColor = true;
            // 
            // Personal_Neu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_personalnr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.rb_arbeiter);
            this.Controls.Add(this.tb_gehalt_lohn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_angestellte);
            this.Name = "Personal_Neu";
            this.Text = "Personal_Neu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_personalnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.RadioButton rb_arbeiter;
        private System.Windows.Forms.TextBox tb_gehalt_lohn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_angestellte;
    }
}