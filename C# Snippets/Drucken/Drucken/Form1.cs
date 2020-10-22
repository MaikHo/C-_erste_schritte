using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drucken {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            RectangleF rec = new RectangleF(50, 70, 750, 1000);
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, rec);
            printDocument1.DocumentName = "Csharp";
            
        }

        private void btn_print_preview_Click(object sender, EventArgs e) {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }
        }

        private void btn_print_Click(object sender, EventArgs e) {
            if (printDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }
        }
    }
}
