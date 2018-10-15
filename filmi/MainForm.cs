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
        string ime, priimek, email, password, kraj;
        int telefon;
        public string mailprijava, passprijava;
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (pass2MaskedTextBox.Text != "" && email2TextBox.Text != "")
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;"+
                    "DATABASE=filmi;" +
                    "UID=filmi;" +
                    "PASSWORD=izet.m;" +
                    "SSLMODE=NONE";
                string reader = "SELECT COUNT(*) AS number FROM filmi.uporabniki WHERE (email='" + email2TextBox.Text + "') AND " +
                    "(password='" + pass2MaskedTextBox.Text + "');";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand read = new MySqlCommand(reader, connection);
                int logstr;
                logstr = Convert.ToInt32(read.ExecuteScalar());
                using (MySqlDataReader login = read.ExecuteReader())
                {
                    if (logstr == 1)
                    {
                        login.Close();
                        mailprijava = email2TextBox.Text;
                        passprijava = pass2MaskedTextBox.Text;
                        string adminMatch = "SELECT vrsta_uporabnika FROM filmi.uporabniki WHERE  (email='" + email2TextBox.Text + "') AND " +
                        "(password='" + pass2MaskedTextBox.Text + "');";
                        MySqlCommand match = new MySqlCommand(adminMatch, connection);
                        string admstr;
                        admstr = match.ExecuteScalar().ToString();
                        if ( admstr == "admin"){
                            adminForm adminForm = new adminForm();
                            adminForm.Show();
                            this.Hide();
                            adminForm.oldPass = passprijava;
                            connection.Close();
                            connection.Open();
                            MySqlCommand getId = new MySqlCommand("SELECT id FROM filmi.uporabniki WHERE  (email='" + email2TextBox.Text + "') AND " +
                            "(password='" + pass2MaskedTextBox.Text + "');",connection);
                            adminForm.upoId = Convert.ToInt32(getId.ExecuteScalar());
                        }
                        else
                        {
                            Movies movies = new Movies();
                            movies.Show();
                            this.Hide();
                        }
                    }
                    else { MessageBox.Show("username and password aren't matched"); }
                }
            }
            else
            {
                MessageBox.Show("username and password aren't matched");
            }
        }

        int cbc =0;
        private void krajComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbc == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT ime FROM filmi.kraji;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader,connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        krajComboBox.Items.Add(read["ime"].ToString());
                        krajComboBox.DisplayMember = read["ime"].ToString();
                    }
                }
                connection.Close();

            }
            cbc = 1;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            ime = imeTextBox.Text;
            priimek = priimekTextBox.Text;
            email = emailTextBox.Text;
            password = passMaskedTextBox.Text;
            kraj = krajComboBox.SelectedItem.ToString();
            DateTime datumroj = dateTimePicker1.Value;
            string datum = datumroj.ToString("yyyy-MM-dd");
            telefon = Convert.ToInt32(telefonTextBox.Text);
            if (ime == "" || priimek == "" || email == "" || kraj=="")
            {
                MessageBox.Show("Not valid values for ime/priimek/email");
            }
            else
            {
                
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                string register = "INSERT INTO filmi.uporabniki(ime,priimek,kraj_id,email,password,telefon," +
                    "datum_roj,vrsta_uporabnika) VALUES ('" + ime + "','" + priimek + "', (SELECT id FROM " +
                    "filmi.kraji WHERE ime='" + kraj + "'),'" + email + "','" + password + "','" + telefon + "'," +
                    "'" + datumroj + "','uporabnik');";
                MySqlCommand regcomm = new MySqlCommand();
                regcomm.CommandText = register;
                regcomm.Connection = connection;
                regcomm.ExecuteNonQuery();
                connection.Close();
                Movies movies = new Movies();
                movies.Show();
                this.Hide();
            }
        }
    }
}
