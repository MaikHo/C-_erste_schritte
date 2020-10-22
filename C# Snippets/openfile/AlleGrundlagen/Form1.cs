using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlleGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region
        // OpenFile offnen
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();     // OpenFile ist hier ne lokale Variable
            OpenFile.Title = "Bitte File auswählen";
            OpenFile.Multiselect = false;                       // Multiselect (Mehrfachauswahl)
            OpenFile.Filter = "Bilder | *.png; *.jpg; *.bnp | PNG-Bilder | *.png";   // welche Dateiformate
            DialogResult DRVariable = OpenFile.ShowDialog();    // was man ausgewählt hat und dann geklickt hat in eine Variable gesteckt

            Image iBild;                            // Variable für das Bild ganz schnell erstellt ^^

            if (DRVariable == DialogResult.OK)      // Wenn OK geklickt passiert
            {
                iBild = Image.FromFile(OpenFile.FileName);  // Variable entspricht jetzt dem Bild
                this.pictureBoxBild.Image = iBild;          // zuweisung des Bildes an die PictureBox
            }
            else
            {
                MessageBox.Show("Kein Bild dabei? ist ja auch nur ein Beispiel", "Name vom Fenster", MessageBoxButtons.OK, MessageBoxIcon.Question); // nur ein Beispiel
            }
        }
        #endregion

        

    }
}
