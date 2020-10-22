using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datenbank {
    public partial class Form1 : Form {
        MySqlConnection connection;
        MySqlCommand command;
        DataSet ds;
        DataTable dt;
        MySqlDataAdapter da;

        public Form1() {
            InitializeComponent();

            string verbindung = "SERVER=localhost;PORT=3306;DATABASE=fiae2;UID=otto;PASSWORD=password;";
            connection = new MySqlConnection(verbindung);

            command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM kunden;";

            // Daten-Container
            ds = new DataSet();
            dt = new DataTable();

            da = new MySqlDataAdapter(command);

            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            da.Fill(ds);

            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;


            //DataGridView dv = new DataGridView();
            //this.Controls.Add(dv);
            //dv.Location = new Point(220, 120);
            //dv.DataSource = ds.Tables[0];

        }

        private void btn_speichern_Click(object sender, EventArgs e) {
            command.CommandText = "INSERT INTO kunden VALUES(" + tb_kd_nr.Text + ", '" + tb_nachname.Text + "');";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btn_daten_lesen_Click(object sender, EventArgs e) {
            lbl_ausgabe.Text = "";
            
            command.CommandText = "SELECT * FROM kunden;";
            connection.Open();
            
            MySqlDataReader reader = command.ExecuteReader();
            lbl_ausgabe.Text = reader.GetName(0) + " " + reader.GetName(1) + "\n";
            while (reader.Read()) {
                lbl_ausgabe.Text += reader.GetInt32(0) + reader.GetString(1) + "\n";
            }
            
            connection.Close();
        }

        private void btn_aktualisieren_Click(object sender, EventArgs e) {
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.Update(ds.Tables[0]);

            ds.Clear();
            da.Fill(ds);
        }
    }
}
