using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace filmi
{
   public partial class MainForm : Form
    {
        string ime, priimek, email, password, telefon, kraj;
        public MainForm()
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
            "DATABASE=filmi;" +
            "UID=filmi;" +
            "PASSWORD=izet.m;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ime = imeTextBox.Text;
            priimek = priimekTextBox.Text;
            email = emailTextBox.Text;
            password = passMaskedTextBox.Text;
            kraj = krajComboBox.ValueMember;
            DateTime datumroj = dateTimePicker1.Value;
            string datum = datumroj.ToString("yyyy-MM-dd");
            telefon = telefonTextBox.Text;
            if (ime == "" || priimek == "" || email == "" || kraj=="")
            {
                MessageBox.Show("Not valid values for ime/priimek/email");
            }
            else
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                string register="INSERT INTO filmi.uporabniki(ime,priimek,kraj_id,email,password,telefon," +
                    "datum_roj,vrsta_uporabnika) VALUES ('"+ ime +"','"+ priimek +"', '(SELECT id FROM" +
                    "filmi.kraji WHERE ime='" + kraj+ "')','" + email + "','')";

            }
        }
    }
}
