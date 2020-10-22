using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML_Daten {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            listView1.Columns.Add("Nachname", 100);
            listView1.Columns.Add("Vorname", 100);
            listView1.Columns.Add("Telefon", 100);

        }

        private void button1_Click(object sender, EventArgs e) {
            XElement mitarbeiterdaten = XElement.Load("daten.xml");

            // Daten mit Linq filter
            IEnumerable<XElement> xe = from m_daten in mitarbeiterdaten.Elements() where m_daten.Element("Tel").Value.StartsWith("030")
                                       orderby m_daten.Element("Nachname").Value descending select m_daten;

            //foreach (XElement item in mitarbeiterdaten.Elements()) {
            foreach (XElement item in xe) {
                ListViewItem lvi = new ListViewItem(item.Element("Nachname").Value);
                lvi.SubItems.Add(item.Element("Vorname").Value);
                lvi.SubItems.Add(item.Element("Tel").Value);
                listView1.Items.Add(lvi);
            }


        }
    }
}
