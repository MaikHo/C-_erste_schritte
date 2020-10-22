using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalverwaltung {
    public partial class Personalliste : Form {
        List<Mitarbeiter> mitarbeiterliste;
        public Personalliste(List<Mitarbeiter> liste) {
            InitializeComponent();
            mitarbeiterliste = liste;
        }

        private void Personalliste_Load(object sender, EventArgs e) {
            lbl_ausgabe.Text = "";

            foreach (Mitarbeiter m in mitarbeiterliste) {
                lbl_ausgabe.Text += m.personalnr + " " + m.vorname + " " + m.nachname + " " + LohnBuchhaltung.Einkommensberechnung(m) + "\n";
                lbl_ausgabe.Text += m.Daten(); // Polymorphie
                lbl_ausgabe.Text += m + "\n\n";
            }


            lv_ausgabe.Columns.Add("Personalnr", 80);
            lv_ausgabe.Columns.Add("Vorname", 100, HorizontalAlignment.Center);
            lv_ausgabe.Columns.Add("Nachname", 120, HorizontalAlignment.Left);
            lv_ausgabe.Columns.Add("Einkommen", 80, HorizontalAlignment.Center);

            foreach (Mitarbeiter m in mitarbeiterliste) {
                ListViewItem item = new ListViewItem(m.personalnr);
                item.SubItems.Add(m.vorname);
                item.SubItems.Add(m.nachname);
                item.SubItems.Add(LohnBuchhaltung.Einkommensberechnung(m).ToString());
                lv_ausgabe.Items.Add(item);
            }
        }
    }
}
