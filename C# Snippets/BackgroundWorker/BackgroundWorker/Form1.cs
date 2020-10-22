using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            for (int i = 0; i < 100; i++) {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage + 1;
            label1.Text = e.ProgressPercentage + 1 + "%";
        }

        private void button1_Click(object sender, EventArgs e) {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show("fertig");
        }

        int zahl;
        private void timer1_Tick(object sender, EventArgs e) {
            zahl++;
            label1.Text = zahl.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            timer1.Start();
        }
    }
}
