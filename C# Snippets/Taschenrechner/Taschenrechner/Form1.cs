using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner {
    public partial class Form1 : Form {
        double zahl1;
        double zahl2;
        string op;


        public Form1() {
            InitializeComponent();
        }

        private void Btn_ziffern_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;

            if (tb_display.Text == "0" & btn.Text != "," ) {
                tb_display.Text = "";
            }

            tb_display.Text += btn.Text;
            
        }

        private void btn_add_Click(object sender, EventArgs e) {
            zahl1 = Convert.ToDouble(tb_display.Text);
            tb_display.Text = "0";
            op = "+";
        }

        private void btn_gleich_Click(object sender, EventArgs e) {
            zahl2 = Convert.ToDouble(tb_display.Text);

            switch (op) {
                case "+":
                    tb_display.Text = Convert.ToString(zahl1 + zahl2);
                    break;
                case "-":
                    tb_display.Text = Convert.ToString(zahl1 - zahl2);
                    break;
                case "*":
                    tb_display.Text = Convert.ToString(zahl1 * zahl2);
                    break;
                case "/":
                    tb_display.Text = Convert.ToString(zahl1 / zahl2);
                    break;
            }


        }
    }
}
