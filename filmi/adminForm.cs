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
    public partial class adminForm : Form
    {
        int ccz=0,ccd=0,cci=0,ccs=0,ccp=0,ccr=0,cbc=0;
        int leto, zasluzek, getMovieId;
        double povp_oc;
        public string ime, opis, zanr, drzava, oldPass;
        public int upoId;
        public adminForm()
        {
            InitializeComponent();
        }

        private void vrsta_upComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void addWriterButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            if (scenaristComboBox.SelectedItem.ToString() == "") MessageBox.Show("Not valid values!");
            else
            {
                string[] splits = scenaristComboBox.SelectedItem.ToString().Split('.');
                string addWriter = "INSERT INTO filmi.scenarsti_filmi(scenarist_id,film_id) VALUES(" + splits[0] + "," + getMovieId + ")";
                connection.Open();
                MySqlCommand insertWriter = new MySqlCommand(addWriter, connection);
                insertWriter.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Writer Successful added!");
            }
        }

        private void producerButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            if (producentComboBox.SelectedItem.ToString() == "") MessageBox.Show("Not valid values!");
            else
            {
                string[] splits = igralecComboBox.SelectedItem.ToString().Split('.');
                string addProducer = "INSERT INTO filmi.producenti_filmi(producent_id,film_id) VALUES(" + splits[0] + "," + getMovieId + ")";
                connection.Open();
                MySqlCommand insertProducer = new MySqlCommand(addProducer, connection);
                insertProducer.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Producer Successful added!");
            }
        }

        private void directorButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            if (directorComboBox.SelectedItem.ToString() == "") MessageBox.Show("Not valid values!");
            else
            {
                string[] splits = directorComboBox.SelectedItem.ToString().Split('.');
                string addDirector = "INSERT INTO filmi.reziserji_filmi(reziser_id,film_id) VALUES(" + splits[0] + "," + getMovieId + ")";
                connection.Open();
                MySqlCommand insertDirector = new MySqlCommand(addDirector, connection);
                insertDirector.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Director Successful added!");
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            string imeup = imeupTextBox.Text;
            string priimek = priimekTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordMaskedTextBox.Text;
            string kraj = krajComboBox.SelectedItem.ToString();
            DateTime datumroj = dat_rojDateTimePicker.Value;
            string datum = datumroj.ToString("yyyy-MM-dd");
            string telefon = telefonTextBox.Text;
            string vrstaup = vrsta_upComboBox.SelectedItem.ToString();
            if (ime == "" || priimek == "" || email == "" || kraj == "" || vrstaup=="")
            {
                MessageBox.Show("Not valid values for ime/priimek/email/vrsta uporabnika");
            }
            else
            {

                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                string register = "INSERT INTO filmi.uporabniki(ime,priimek,kraj_id,email,password,telefon," +
                    "datum_roj,vrsta_uporabnika) VALUES ('" + ime + "','" + priimek + "', (SELECT id FROM " +
                    "filmi.kraji WHERE ime='" + kraj + "'),'" + email + "','" + password + "','" + telefon + "'," +
                    "'" + datumroj + "','"+vrstaup+"');";
                MySqlCommand regcomm = new MySqlCommand();
                regcomm.CommandText = register;
                regcomm.Connection = connection;
                regcomm.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully added user!");
            }
        }

        private void changeVrUpoButton_Click(object sender, EventArgs e)
        {
            if (emailChangeTextBox.Text !="" && vrsta_upChangeComboBox.SelectedItem.ToString()!="")
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                string newPass = "UPDATE filmi.uporabniki SET vrsta_uporabnika='" + vrsta_upChangeComboBox.SelectedItem.ToString() + "' " +
                    "WHERE email='" + emailChangeTextBox.Text + "';";
                MySqlCommand change = new MySqlCommand(newPass, connection);
                change.ExecuteNonQuery();
                MessageBox.Show("Type of user was changed.");
                connection.Close();
            }
            else MessageBox.Show("Don't valid values!");
        }

        private void viewMoviesButton_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            movies.Show();
            this.Hide();
        }

        public void changePassButton_Click(object sender, EventArgs e)
        {
            if (newPassMaskedTextBox.Text != "")
            {
                if (oldPassMaskedTextBox.Text == oldPass)
                {
                    string MyConString = "SERVER=den1.mysql2.gear.host;" +
                    "PORT=3306;" +
                    "DATABASE=filmi;" +
                    "UID=filmi;" +
                    "PASSWORD=izet.m;" +
                    "SSLMODE=NONE";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    connection.Open();
                    string newPass = "UPDATE filmi.uporabniki SET password='" + newPassMaskedTextBox.Text + "' " +
                        "WHERE id=" + upoId + ";";
                    MySqlCommand change = new MySqlCommand(newPass, connection);
                    change.ExecuteNonQuery();
                    MessageBox.Show("Password changed.");
                    connection.Close();
                }
                else MessageBox.Show("Password don't match!");
            }
            else MessageBox.Show("New password can't be empty!");
        }

        private void scenaristComboBox_Click(object sender, EventArgs e)
        {
            if (ccs == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT id, ime, priimek FROM filmi.scenaristi;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        scenaristComboBox.Items.Add(read["id"]+"."+read["ime"].ToString() + " " + read["priimek"].ToString());
                        scenaristComboBox.DisplayMember =read["id"] +"."+ read["ime"].ToString() + " " + read["priimek"].ToString();
                    }
                }
            }
            ccs = 1;
        }

        private void producentComboBox_Click(object sender, EventArgs e)
        {
            if (ccp == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT id, ime, priimek FROM filmi.producenti;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        producentComboBox.Items.Add(read["id"].ToString()+"."+read["ime"].ToString() + " " + read["priimek"].ToString());
                        producentComboBox.DisplayMember = read["id"].ToString() + "." +read["ime"].ToString() + " " + read["priimek"].ToString();
                    }
                }
            }
            ccp = 1;
        }

        private void directorComboBox_Click(object sender, EventArgs e)
        {
            if (ccr == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT id, ime, priimek FROM filmi.reziserji;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        directorComboBox.Items.Add(read["id"].ToString() + "." + read["ime"].ToString() + " " + read["priimek"].ToString());
                        directorComboBox.DisplayMember = read["id"].ToString() + "." + read["ime"].ToString() + " " + read["priimek"].ToString();
                    }
                }
            }
            ccr = 1;
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            ime = imeFilmaTextBox.Text;
            Double.TryParse(povp_ocTextBox.Text, out povp_oc);
            int.TryParse(zaslužekTextBox.Text, out zasluzek);
            int.TryParse(letnicaTextBox.Text, out leto);
            opis = opisTextBox.Text; if (ime == "" || povp_ocTextBox.Text == "" || zaslužekTextBox.Text == "" ||
                 letnicaTextBox.Text == "" || zanrComboBox.SelectedItem.ToString() == "" 
                 || drzavaComboBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Not valid values");
            }
            else
            {
                zanr = zanrComboBox.SelectedItem.ToString();
                drzava = drzavaComboBox.SelectedItem.ToString();
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                string addMovie = "INSERT INTO filmi.filmi(ime_filma,zanr_id,drzava_id,leto_p,povp_ocena_imdb" +
                    ",zasluzek,opis) VALUES ('" + ime + "',(SELECT id FROM filmi.zanri WHERE ime='"+zanr+"')," +
                    " (SELECT id FROM filmi.drzave WHERE ime='" + drzava + "')," + leto + "," + povp_oc + "," +
                    zasluzek + ", '" + opis + "');";
                MySqlCommand adding = new MySqlCommand();
                adding.CommandText = addMovie;
                adding.Connection = connection;
                adding.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie successeful added!\nNow, you can add actors,producers etc.");
                connection.Open();
                string movie_id = "SELECT id FROM filmi.filmi WHERE ime_filma='"+ime+"'";
                MySqlCommand gmid = new MySqlCommand();
                gmid.CommandText = movie_id;
                gmid.Connection = connection;
                getMovieId= Convert.ToInt32(gmid.ExecuteScalar());
                connection.Close();
            }
        }
        private void krajComboBox_Click(object sender, EventArgs e)
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
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

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

        private void zanrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void zanrComboBox_Click(object sender, EventArgs e)
        {
            if (ccz == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT ime FROM filmi.zanri;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        zanrComboBox.Items.Add(read["ime"].ToString());
                        zanrComboBox.DisplayMember = read["ime"].ToString();
                    }
                }


            }
            ccz = 1;
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void igralecComboBox_Click(object sender, EventArgs e)
        {
            if (cci == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT id, ime, priimek FROM filmi.igralci;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        igralecComboBox.Items.Add(read["id"].ToString()+"."+read["ime"].ToString()+" "+read["priimek"].ToString());
                        igralecComboBox.DisplayMember = read["id"].ToString() + "." + read["ime"].ToString() + " " + read["priimek"].ToString();
                    }
                }
            }
            cci = 1;
        }
        private void addActorButton_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            if (igralecComboBox.SelectedItem.ToString() == "") MessageBox.Show("Not valid values!");
            else {
                string[] splits = igralecComboBox.SelectedItem.ToString().Split('.');
                string addActor = "INSERT INTO filmi.igralci_filmi(igralec_id,film_id) VALUES("+splits[0]+","+getMovieId+")";
                connection.Open();
                MySqlCommand insertActor = new MySqlCommand(addActor, connection);
                insertActor.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Actor Successful added!");
            }
        }
        private void drzavaComboBox_Click(object sender, EventArgs e)
        {
            if (ccd == 0)
            {
                string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
                string reader = "SELECT ime FROM filmi.drzave;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        drzavaComboBox.Items.Add(read["ime"].ToString());
                        drzavaComboBox.DisplayMember = read["ime"].ToString();
                    }
                }


            }
            ccd = 1;
        }
    }
}
