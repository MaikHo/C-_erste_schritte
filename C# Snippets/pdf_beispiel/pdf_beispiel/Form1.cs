using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace pdf_beispiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfDocument dokument = new PdfDocument();
            dokument.Info.Author = "ich";
            dokument.Info.Title = "Cscharp PDF";

            PdfPage seite1 = dokument.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(seite1);

            XTextFormatter tf = new XTextFormatter(gfx);
            XFont font = new XFont("Calibri", 12, XFontStyle.Regular);
            XRect rec = new XRect(20, 20, seite1.Width - 40, 200);

            tf.DrawString(richTextBox1.Text, font, XBrushes.Red, rec);

            dokument.Save("test.pdf");

            Process.Start("test.pdf");
        }
    }
}
