using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grundlagen_Telefonbuch
{
    public partial class FormMain : Form
    {
        
        #region Variablen
        
        #region string
        
        // string sVorname;
        // string sName;
        // string sTelefonnummer;
        // string sMail;
        // string sAusgabe;
        // string sFunktionTextSpeichern;
        

        #endregion
        
        #region irgerndwas nachher
        
        
        
        #endregion
        
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region Speicherknopf (Aufruf Funktion TextSpeichern ohne Rückgabewert)
        /*
        // Speichernknopf
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            TextSpeichern();    // Aufruf der Funktion für den Speicherknopf (können mehrmals aufgerufen werden)
        }
         */
        #endregion

        #region Speicherknopf (Aufruf Funktion TextSpeichern mit Rückgabewert)
        /*
        // Speichernknopf
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {   // Variable                 // Funktion
            sFunktionTextSpeichern = TextSpeichern();    // Aufruf der Funktion für den Speicherknopf (über die Variable)

            // Ausgabe der Variablen in der Textbox
            this.richTextBoxAusgabe.Text += sFunktionTextSpeichern;
        }
         */
        #endregion

        #region Speicherknopf (Aufruf Funktion TextSpeichern mit Rückgabewert ganz kurz)
        // Speichernknopf
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {   
            // Ausgabe der Funktion in der Textbox
            this.richTextBoxAusgabe.Text += TextSpeichern();     
        }
        #endregion

        #region Funktion TextSpeichern ohne Rückgabewert
        /*
        // Funktion für den Speicherknopf
        void TextSpeichern()    // void gibt uns keinen Wert mit dem wir weiterarbeiten können
        {
            sVorname = this.textBoxVorname.Text;                // Textboxeingabe mit der Variablen verknüpfen
            sName = this.textBoxName.Text;                      // Textboxeingabe mit der Variablen verknüpfen
            sTelefonnummer = this.textBoxTelefonnummer.Text;    // Textboxeingabe mit der Variablen verknüpfen
            sMail = this.textBoxMail.Text;                      // Textboxeingabe mit der Variablen verknüpfen

            // Variable wird verknüpft mit den anderen Variablen (durch +) ("Text wird mit angezeigt") (\n = neue Zeile wird angefangen)
            sAusgabe = "Vorname:" + sVorname + "\nName: " + sName + "\nTelefon: " + sTelefonnummer + "\nMail: " + sMail + "\n\n";   // "\n\n" für ne leere Zeile


            // Ausgabe der Variablen in der Textbox
            this.richTextBoxAusgabe.Text += sAusgabe;

            // Hier steht alles einzeln, oben die Kurzform
            // this.richTextBoxAusgabe.Text = "Vorname: " +sVorname;
            // this.richTextBoxAusgabe.Text += "\nName: " +sName;
            // this.richTextBoxAusgabe.Text += "\nTelefon: " +sTelefonnummer;
            // this.richTextBoxAusgabe.Text += "\nMail: " +sMail; 
        }
         */ 
        #endregion

        #region Funktion TextSpeichern mit Rückgabewert
        /*
        // Funktion für den Speicherknopf
        string TextSpeichern()    // void gibt uns keinen Wert mit dem wir weiterarbeiten können
        {
            sVorname = this.textBoxVorname.Text;                // Textboxeingabe mit der Variablen verknüpfen
            sName = this.textBoxName.Text;                      // Textboxeingabe mit der Variablen verknüpfen
            sTelefonnummer = this.textBoxTelefonnummer.Text;    // Textboxeingabe mit der Variablen verknüpfen
            sMail = this.textBoxMail.Text;                      // Textboxeingabe mit der Variablen verknüpfen

            // Variable wird verknüpft mit den anderen Variablen (durch +) ("Text wird mit angezeigt") (\n = neue Zeile wird angefangen)
            sAusgabe = "Vorname:" + sVorname + "\nName: " + sName + "\nTelefon: " + sTelefonnummer + "\nMail: " + sMail + "\n\n";   // "\n\n" für ne leere Zeile

            return sAusgabe;    // Ausgabewert (Variable wird ausgegeben)
        }
         */ 
        #endregion

        #region Funktion TextSpeichern mit Rückgabewert ganz kurz

        // Funktion für den Speicherknopf
        string TextSpeichern()    // void gibt uns keinen Wert mit dem wir weiterarbeiten können
        {
            // sVorname              // Variable wird hier nicht gebraucht
            // sName                 // Variable wird hier nicht gebraucht
            // sTelefonnummer        // Variable wird hier nicht gebraucht
            // sMail                 // Variable wird hier nicht gebraucht

            /*
                // Variable wird verknüpft den Eingaben in den Texboxen (durch +) ("Text wird mit angezeigt") (\n = neue Zeile wird angefangen)
                sAusgabe = "Vorname:" + this.textBoxVorname.Text + "\nName: " + this.textBoxName.Text + "\nTelefon: " + this.textBoxTelefonnummer.Text + "\nMail: " + this.textBoxMail.Text + "\n\n";   // "\n\n" für ne leere Zeile

                return sAusgabe;    // Ausgabewert (Variable wird ausgegeben)
            */

            // die kürzeste Form (
            return  "Vorname:" + this.textBoxVorname.Text + "\nName: " + this.textBoxName.Text + "\nTelefon: " + this.textBoxTelefonnummer.Text + "\nMail: " + this.textBoxMail.Text + "\n\n";
        }
        #endregion

        #region Löschenknopf
        // Löschenknopf
        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            if (this.checkBoxLoechen.Checked)   // hier default true (wahr) (also Harken gesetzt)
            {
                
                // Sicherheitsabfrage
                // DialogResult DR = new System.Windows.Forms.DialogResult();   // Irgendwie Funktioniert es so nicht???
                // MessageBox.Show("Wirklich alles Löschen?", "Sicherheitsabfrage zum Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                // Das ist das gleiche wie:
                 DialogResult DR = MessageBox.Show("Wirklich alles Löschen?", "Sicherheitsabfrage zum Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (DR == DialogResult.Yes) // wenn Yes gedrückt wird passiert das
                {
                    DeleteAlles();
                }
                else
                {
 
                }
                
            }
            else                                // wenn kein Haken (false = nicht wahr)
            {   
                DeleteOben();
                
            }
        }
        #endregion

        #region Funktionen Löschen (2 Stück)
        // Funktion oben Löschen
        void DeleteOben()
        {
            this.textBoxVorname.Text = "";
            this.textBoxName.Text = "";
            this.textBoxTelefonnummer.Text = "";
            this.textBoxMail.Text = "";
        }

        // Funktion alles Löschen
        void DeleteAlles()
        {
            this.textBoxVorname.Text = "";
            this.textBoxName.Text = "";
            this.textBoxTelefonnummer.Text = "";
            this.textBoxMail.Text = "";
            this.richTextBoxAusgabe.Text = "";
        }
        #endregion

        #region Funktionen Switch
        /*
        // Funktion switsch case  (Wichtig: hier exsistiert keine ComboBox, deswegen ein Fehler)
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        switch (this.ComboBox.SelectedIndex)
        {
            case 0:
                DeleteAlles();
                break;
            case 1:
                MessageBox;
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }
        }
        */
        #endregion

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