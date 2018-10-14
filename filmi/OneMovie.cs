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
    public partial class OneMovie : Form
    {
        public string id;
        public OneMovie()
        {
            InitializeComponent();
            /*string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand forMovie = new MySqlCommand("SELECT f.id, f.ime_filma, f.leto_p, f.povp_ocena_imdb, z.ime, d.ime AS drzava,f.opis, f.zasluzek" +
                " FROM filmi.drzave d INNER JOIN filmi.filmi f ON f.drzava_id=d.id INNER JOIN filmi.zanri z ON f.zanr_id=z.id WHERE f.id="+id+";", connection);
            connection.Open();
            using (MySqlDataReader read = forMovie.ExecuteReader()) {
                label1.Text = read["ime_filma"].ToString();
            }*/
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string MyConString = "SERVER=den1.mysql2.gear.host;" +
                "PORT=3306;" +
                "DATABASE=filmi;" +
                "UID=filmi;" +
                "PASSWORD=izet.m;" +
                "SSLMODE=NONE";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand forMovie = new MySqlCommand("SELECT f.id, f.ime_filma, f.leto_p, f.povp_ocena_imdb, z.ime, d.ime AS drzava,f.opis, f.zasluzek" +
                " FROM filmi.drzave d INNER JOIN filmi.filmi f ON f.drzava_id=d.id INNER JOIN filmi.zanri z ON f.zanr_id=z.id WHERE f.id=" + id + ";", connection);
            connection.Open();
            MySqlDataReader movie = forMovie.ExecuteReader();
            movie.Read();
            double zasluzek;
            Double.TryParse(movie["zasluzek"].ToString(),out zasluzek);
            label1.Text = movie["ime_filma"].ToString() + "  " + movie["ime"].ToString() + "  " + movie["drzava"].ToString() + "  " + movie["leto_p"].ToString();
            label2.Text= "Zaslužek: "+zasluzek + "  Povprečna ocena(imdb): " + movie["povp_ocena_imdb"].ToString() + "\n" + movie["opis"].ToString();
            movie.Close();
            MySqlCommand actors = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.igralci i INNER JOIN " +
                "filmi.igralci_filmi fi ON fi.igralec_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id="+id+";",connection);
            /*MySqlDataReader actor = actors.ExecuteReader();
            igralci.Text = actor["ime"].ToString()+" "+actor["priimek"].ToString();*/
        }
    }
}
