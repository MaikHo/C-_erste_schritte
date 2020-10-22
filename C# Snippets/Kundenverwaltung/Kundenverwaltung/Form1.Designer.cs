namespace Kundenverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_KdNR = new System.Windows.Forms.Label();
            this.tb_KdNR = new System.Windows.Forms.TextBox();
            this.lb_Anrede = new System.Windows.Forms.Label();
            this.combobox_Anrede = new System.Windows.Forms.ComboBox();
            this.lb_Nachname = new System.Windows.Forms.Label();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.lb_Newsletter = new System.Windows.Forms.Label();
            this.checkBox_Newsletter = new System.Windows.Forms.CheckBox();
            this.rb_privat = new System.Windows.Forms.RadioButton();
            this.rb_gewerbe = new System.Windows.Forms.RadioButton();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.lb_ausgabe = new System.Windows.Forms.Label();
            this.btn_anzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_KdNR
            // 
            this.lb_KdNR.AutoSize = true;
            this.lb_KdNR.Location = new System.Drawing.Point(41, 68);
            this.lb_KdNR.Name = "lb_KdNR";
            this.lb_KdNR.Size = new System.Drawing.Size(39, 13);
            this.lb_KdNR.TabIndex = 0;
            this.lb_KdNR.Text = "KdNR.";
            // 
            // tb_KdNR
            // 
            this.tb_KdNR.Location = new System.Drawing.Point(103, 61);
            this.tb_KdNR.Name = "tb_KdNR";
            this.tb_KdNR.Size = new System.Drawing.Size(100, 20);
            this.tb_KdNR.TabIndex = 1;
            // 
            // lb_Anrede
            // 
            this.lb_Anrede.AutoSize = true;
            this.lb_Anrede.Location = new System.Drawing.Point(41, 95);
            this.lb_Anrede.Name = "lb_Anrede";
            this.lb_Anrede.Size = new System.Drawing.Size(41, 13);
            this.lb_Anrede.TabIndex = 2;
            this.lb_Anrede.Text = "Anrede";
            // 
            // combobox_Anrede
            // 
            this.combobox_Anrede.FormattingEnabled = true;
            this.combobox_Anrede.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.combobox_Anrede.Location = new System.Drawing.Point(103, 87);
            this.combobox_Anrede.Name = "combobox_Anrede";
            this.combobox_Anrede.Size = new System.Drawing.Size(121, 21);
            this.combobox_Anrede.TabIndex = 3;
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.AutoSize = true;
            this.lb_Nachname.Location = new System.Drawing.Point(38, 131);
            this.lb_Nachname.Name = "lb_Nachname";
            this.lb_Nachname.Size = new System.Drawing.Size(59, 13);
            this.lb_Nachname.TabIndex = 4;
            this.lb_Nachname.Text = "Nachname";
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Location = new System.Drawing.Point(103, 124);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(100, 20);
            this.tb_Nachname.TabIndex = 5;
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(103, 150);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(100, 20);
            this.tb_Vorname.TabIndex = 7;
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Location = new System.Drawing.Point(38, 157);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(49, 13);
            this.lb_Vorname.TabIndex = 6;
            this.lb_Vorname.Text = "Vorname";
            // 
            // lb_Newsletter
            // 
            this.lb_Newsletter.AutoSize = true;
            this.lb_Newsletter.Location = new System.Drawing.Point(38, 208);
            this.lb_Newsletter.Name = "lb_Newsletter";
            this.lb_Newsletter.Size = new System.Drawing.Size(57, 13);
            this.lb_Newsletter.TabIndex = 8;
            this.lb_Newsletter.Text = "Newsletter";
            // 
            // checkBox_Newsletter
            // 
            this.checkBox_Newsletter.AutoSize = true;
            this.checkBox_Newsletter.Location = new System.Drawing.Point(103, 204);
            this.checkBox_Newsletter.Name = "checkBox_Newsletter";
            this.checkBox_Newsletter.Size = new System.Drawing.Size(70, 17);
            this.checkBox_Newsletter.TabIndex = 9;
            this.checkBox_Newsletter.Text = "Ja / Nein";
            this.checkBox_Newsletter.UseVisualStyleBackColor = true;
            // 
            // rb_privat
            // 
            this.rb_privat.AutoSize = true;
            this.rb_privat.Checked = true;
            this.rb_privat.Location = new System.Drawing.Point(103, 254);
            this.rb_privat.Name = "rb_privat";
            this.rb_privat.Size = new System.Drawing.Size(52, 17);
            this.rb_privat.TabIndex = 10;
            this.rb_privat.TabStop = true;
            this.rb_privat.Text = "Privat";
            this.rb_privat.UseVisualStyleBackColor = true;
            // 
            // rb_gewerbe
            // 
            this.rb_gewerbe.AutoSize = true;
            this.rb_gewerbe.Location = new System.Drawing.Point(218, 254);
            this.rb_gewerbe.Name = "rb_gewerbe";
            this.rb_gewerbe.Size = new System.Drawing.Size(68, 17);
            this.rb_gewerbe.TabIndex = 11;
            this.rb_gewerbe.Text = "Gewerbe";
            this.rb_gewerbe.UseVisualStyleBackColor = true;
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(103, 319);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_speichern.TabIndex = 12;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // lb_ausgabe
            // 
            this.lb_ausgabe.AutoSize = true;
            this.lb_ausgabe.Location = new System.Drawing.Point(483, 71);
            this.lb_ausgabe.Name = "lb_ausgabe";
            this.lb_ausgabe.Size = new System.Drawing.Size(49, 13);
            this.lb_ausgabe.TabIndex = 13;
            this.lb_ausgabe.Text = "Ausgabe";
            // 
            // btn_anzeigen
            // 
            this.btn_anzeigen.Location = new System.Drawing.Point(486, 318);
            this.btn_anzeigen.Name = "btn_anzeigen";
            this.btn_anzeigen.Size = new System.Drawing.Size(75, 24);
            this.btn_anzeigen.TabIndex = 14;
            this.btn_anzeigen.Text = "Anzeigen";
            this.btn_anzeigen.UseVisualStyleBackColor = true;
            this.btn_anzeigen.Click += new System.EventHandler(this.btn_anzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 558);
            this.Controls.Add(this.btn_anzeigen);
            this.Controls.Add(this.lb_ausgabe);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.rb_gewerbe);
            this.Controls.Add(this.rb_privat);
            this.Controls.Add(this.checkBox_Newsletter);
            this.Controls.Add(this.lb_Newsletter);
            this.Controls.Add(this.tb_Vorname);
            this.Controls.Add(this.lb_Vorname);
            this.Controls.Add(this.tb_Nachname);
            this.Controls.Add(this.lb_Nachname);
            this.Controls.Add(this.combobox_Anrede);
            this.Controls.Add(this.lb_Anrede);
            this.Controls.Add(this.tb_KdNR);
            this.Controls.Add(this.lb_KdNR);
            this.Name = "Form1";
            this.Text = "Kundenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_KdNR;
        private System.Windows.Forms.TextBox tb_KdNR;
        private System.Windows.Forms.Label lb_Anrede;
        private System.Windows.Forms.ComboBox combobox_Anrede;
        private System.Windows.Forms.Label lb_Nachname;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.Label lb_Newsletter;
        private System.Windows.Forms.CheckBox checkBox_Newsletter;
        private System.Windows.Forms.RadioButton rb_privat;
        private System.Windows.Forms.RadioButton rb_gewerbe;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.Label lb_ausgabe;
        private System.Windows.Forms.Button btn_anzeigen;
    }
}

