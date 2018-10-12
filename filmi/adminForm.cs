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
        int ccz;
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
    }
}
