using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenverwaltung
{
    public partial class Form1 : Form
    {
        string[,] kunden = new string[10, 6];
        int anz_kunden;                             // ist beim erstenmal automatisch die 0

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            kunden[anz_kunden, 0] = tb_KdNR.Text;
            kunden[anz_kunden, 1] = combobox_Anrede.Text;
            kunden[anz_kunden, 2] = tb_Nachname.Text;
            kunden[anz_kunden, 3] = tb_Vorname.Text;

            if (checkBox_Newsletter.Checked)
                kunden[anz_kunden, 4] = "Ja";
            else
                kunden[anz_kunden, 4] = "Nein";


            if (rb_privat.Checked)
                kunden[anz_kunden, 5] = "Privat";
            else
                kunden[anz_kunden, 5] = "Gewerbe";


            anz_kunden++;                           // Hier wird die Variable hochgezählt

            MessageBox.Show("Kunde angelegt");
       
        }

        private void btn_anzeigen_Click(object sender, EventArgs e)
        {
            lb_ausgabe.Text = "";

            for(int i = 0; i < anz_kunden; i++)

            lb_ausgabe.Text +=                      // die alten sachen werden davor angekettet
                    kunden[i, 0] + " " + 
                    kunden[i, 1] + " " + 
                    kunden[i, 2] + " " + 
                    kunden[i, 3] + " " +
                    kunden[i, 4] + " " + 
                    kunden[i, 5] + "\n";
        }
    }
}
