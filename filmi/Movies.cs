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
    public partial class Movies : Form
    {
        public int id_filma;
        public string[] splits;
        public Movies()
        {
            InitializeComponent();
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            connection.Open();
            MySqlCommand comm = new MySqlCommand("SELECT f.id, f.ime_filma, f.leto_p, f.povp_ocena_imdb, z.ime" +
                " FROM filmi.filmi f INNER JOIN filmi.zanri z ON f.zanr_id=z.id;", connection);
            using (MySqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    filmiListBox.Items.Add(read["id"].ToString()+"."+read["ime_filma"]+"   "+read["leto_p"]
                        +"   "+read["ime"]+"   "+read["povp_ocena_imdb"]);
                    filmiListBox.DisplayMember = read["id"].ToString() + "." + read["ime_filma"] + "   " + read["leto_p"]
                        + "   " + read["ime"] + "   " + read["povp_ocena_imdb"];
                }
                connection.Close();
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OneMovie movie = new OneMovie();
            movie.Show();
        }

        private void filmiDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void filmiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            splits = filmiListBox.SelectedItem.ToString().Split('.');
            OneMovie movie = new OneMovie();
            movie.id = splits[0];
            movie.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
