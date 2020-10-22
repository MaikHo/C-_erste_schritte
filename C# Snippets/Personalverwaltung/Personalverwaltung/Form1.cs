using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalverwaltung {
    public partial class Form1 : Form {
        List<Mitarbeiter> mitarbeiterliste = new List<Mitarbeiter>();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FileStream fs = null;
            try {
                fs = new FileStream("mitarbeiterliste.sav", FileMode.Open);
                BinaryFormatter bifo = new BinaryFormatter();
                mitarbeiterliste = (List<Mitarbeiter>)bifo.Deserialize(fs);
            } catch (FileNotFoundException ex1) {
                MessageBox.Show(ex1.Message);
            } catch (Exception ex) {
                MessageBox.Show("irgendein Fehler");
            } finally {
                fs.Close();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            FileStream fs = null;
            try {
                fs = new FileStream("mitarbeiterliste.sav", FileMode.Create);
                BinaryFormatter bifo = new BinaryFormatter();
                bifo.Serialize(fs, mitarbeiterliste);
            } catch (UnauthorizedAccessException ex) {
                MessageBox.Show("Kein Zugriff auf das Verzeichniss");
            } catch (Exception ex) {
                MessageBox.Show("irgendein Fehler");
            } finally {
                fs.Close();
            }

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Personalverwaltung\nVersion 1.0");
        }

        private void exportierenCSVToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = "export.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                foreach (Mitarbeiter m in mitarbeiterliste) {
                    if(m is Arbeiter)
                        sw.WriteLine(m.personalnr + "," + m.vorname + "," + m.nachname + "," + ((Arbeiter)m).stdlohn + "," + 0);
                    else if(m is Angestellte)
                        sw.WriteLine(m.personalnr + "," + m.vorname + "," + m.nachname + "," + ((Angestellte)m).gehalt + "," + 1);
                }
                sw.Close();
            }
        }

        private void importierenCSVToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string zeile;
                while ( (zeile = sr.ReadLine()) != null ) {
                    string[] daten = zeile.Split(',');
                    if(daten[4] == "0")
                        mitarbeiterliste.Add(new Arbeiter(daten[0], daten[1], daten[2], Convert.ToDouble(daten[3])));
                    else if(daten[4] == "1")
                        mitarbeiterliste.Add(new Angestellte(daten[0], daten[1], daten[2], Convert.ToDouble( daten[3] ) ));
                                        
                }
                                
                sr.Close();
            }
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e) {
            new Personal_Neu(mitarbeiterliste).Show();
        }

        private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e) {
            new Personalliste(mitarbeiterliste).Show();
        }
    }
}
