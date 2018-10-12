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
                string reader = "SELECT ime, priimek FROM filmi.scenaristi;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        scenaristComboBox.Items.Add(read["ime"].ToString() + " " + read["priimek"].ToString());
                        scenaristComboBox.DisplayMember = read["ime"].ToString() + " " + read["priimek"].ToString();
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
                string reader = "SELECT ime, priimek FROM filmi.producenti;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        producentComboBox.Items.Add(read["ime"].ToString() + " " + read["priimek"].ToString());
                        producentComboBox.DisplayMember = read["ime"].ToString() + " " + read["priimek"].ToString();
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
                string reader = "SELECT ime, priimek FROM filmi.reziserji;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        directorComboBox.Items.Add(read["ime"].ToString() + " " + read["priimek"].ToString());
                        directorComboBox.DisplayMember = read["ime"].ToString() + " " + read["priimek"].ToString();
                    }
                }
            }
            ccr = 1;
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
                string reader = "SELECT ime, priimek FROM filmi.igralci;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                MySqlCommand showkraj = new MySqlCommand(reader, connection);

                using (MySqlDataReader read = showkraj.ExecuteReader())
                {
                    while (read.Read())
                    {
                        igralecComboBox.Items.Add(read["ime"].ToString()+" "+read["priimek"].ToString());
                        igralecComboBox.DisplayMember = read["ime"].ToString() + " " + read["priimek"].ToString();
                    }
                }
            }
            cci = 1;
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
