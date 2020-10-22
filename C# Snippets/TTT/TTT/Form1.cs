﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int X = 50;
            int Y = 50;

            for (int i = 0; i < 9; i++)
            {
                Button feld = new Button();
                this.Controls.Add(feld);
                feld.Text = Convert.ToString( i  +  1);
                feld.Size = new Size(50, 50);
                feld.Location = new Point(X, Y);
                feld.Click += btn_click_feld;
                X += 60;
                if (i % 3 == 2 )
                {
                    Y += 60;
                    X = 50;
                }

            }


        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_click_feld(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text);
        }
    }
}
