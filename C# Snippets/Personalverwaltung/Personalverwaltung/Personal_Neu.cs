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
    public partial class Personal_Neu : Form {
        List<Mitarbeiter> mitarbeiterliste;
        public Personal_Neu(List<Mitarbeiter> liste) {
            InitializeComponent();
            mitarbeiterliste = liste;
        }

        private void btn_speichern_Click(object sender, EventArgs e) {
            if (rb_angestellte.Checked) {
                Angestellte ang = new Angestellte(tb_personalnr.Text, tb_vorname.Text, tb_nachname.Text, Convert.ToDouble(tb_gehalt_lohn.Text));
                mitarbeiterliste.Add(ang);

            } else {
                Arbeiter arb = new Arbeiter(tb_personalnr.Text, tb_vorname.Text, tb_nachname.Text, Convert.ToDouble(tb_gehalt_lohn.Text));
                mitarbeiterliste.Add(arb);
            }
        }


    }
}
