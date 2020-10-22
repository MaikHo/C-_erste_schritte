using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex = Microsoft.Office.Interop.Excel;
using Wd = Microsoft.Office.Interop.Word;

namespace MSOffice {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_excel_Click(object sender, EventArgs e) {
            Ex.Application MSExcel = new Ex.Application();
            MSExcel.Visible = false;
            MSExcel.ScreenUpdating = true;

            Ex.Workbook wb = MSExcel.Workbooks.Add();
            Ex.Worksheet tabelle1 = wb.Worksheets[1];
            Ex.Worksheet tabelle2 = wb.Worksheets.Add();
            tabelle2.Name = "Csharp";

            tabelle1.Cells[1, 1] = "Text von Csharp";
            Ex.Range range1 = tabelle1.Range["A1", "C3"];
            range1.Font.Bold = true;
            range1.Font.ColorIndex = 3;

            //wb.SaveAs(@"c:\csharp FIAE 2\test.xlsx");
            MSExcel.Quit();
        }

        private void btn_word_Click(object sender, EventArgs e) {
            Wd.Application MSWord = new Wd.Application();
            MSWord.Visible = true;
            MSWord.ScreenUpdating = true;

            // Neue Seite anlegen
            Wd.Document dokument1 = MSWord.Documents.Add();
            //Wd.Paragraph absatz1 = dokument1.Paragraphs.Add();
            MSWord.Selection.TypeText("Text von Csharp");
            MSWord.Selection.TypeParagraph();
            MSWord.Selection.Font.Name = "Verdana";
            MSWord.Selection.Font.Size = 16;
            MSWord.Selection.TypeText("Text2 von Csharp");

            // Vorlagen öffnen
            //MSWord.Documents.Open("vorlage.docx");

            // Drucken
            //dokument1.PrintPreview();


        }
    }
}
