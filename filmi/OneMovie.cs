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
            /*string MyConString = "SERVER=den1.mysql2.gear.host;" +
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
            int i=0;
            using (MySqlDataReader actor = actors.ExecuteReader())
            {
                while (actor.Read())
                {
                    if (i == 1)
                    {
                        igralci.Text = igralci.Text + ", " + actor["ime"].ToString()
                            + " " + actor["priimek"].ToString();
                    }
                    else
                    {
                        igralci.Text = "Igralci: " + actor["ime"].ToString() + " " + actor["priimek"].ToString();
                        i = 1;
                    }
                }
            }
            MySqlCommand writers = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.scenaristi i INNER JOIN " +
                "filmi.scenarsti_filmi fi ON fi.scenarist_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
             i = 0;
            using (MySqlDataReader writer = writers.ExecuteReader())
            {
                while (writer.Read())
                {
                    if (i == 1)
                    {
                        scenaristi.Text = scenaristi.Text + ", " + writer["ime"].ToString()
                            + " " + writer["priimek"].ToString();
                    }
                    else
                    {
                        scenaristi.Text = "Scenaristi: " + writer["ime"].ToString() + " " + writer["priimek"].ToString();
                        i = 1;
                    }
                }
            }
            MySqlCommand producers = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.producenti i INNER JOIN " +
                "filmi.producenti_filmi fi ON fi.producent_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
            i = 0;
            using (MySqlDataReader producer = producers.ExecuteReader())
            {
                while (producer.Read())
                {
                    if (i == 1)
                    {
                        producenti.Text = producenti.Text + ", " + producer["ime"].ToString()
                            + " " + producer["priimek"].ToString();
                    }
                    else
                    {
                        producenti.Text = "Producentii: " + producer["ime"].ToString() + " " + producer["priimek"].ToString();
                        i = 1;
                    }
                }
            }
            MySqlCommand directors = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.reziserji i INNER JOIN " +
                "filmi.reziserji_filmi fi ON fi.reziser_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
            i = 0;
            using (MySqlDataReader director = directors.ExecuteReader())
            {
                while (director.Read())
                {
                    if (i == 1)
                    {
                        reziserji.Text = reziserji.Text + ", " + director["ime"].ToString()
                            + " " + director["priimek"].ToString();
                    }
                    else
                    {
                        reziserji.Text = "Režiserji: " + director["ime"].ToString() + " " + director["priimek"].ToString();
                        i = 1;
                    }
                }
            }*/
        }

        private void OneMovie_Load(object sender, EventArgs e)
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
            Double.TryParse(movie["zasluzek"].ToString(), out zasluzek);
            label1.Text = movie["ime_filma"].ToString() + "  " + movie["ime"].ToString() + "  " + movie["drzava"].ToString() + "  " + movie["leto_p"].ToString();
            label2.Text = "Zaslužek: " + zasluzek + "  Povprečna ocena(imdb): " + movie["povp_ocena_imdb"].ToString() + "\n" + movie["opis"].ToString();
            movie.Close();
            MySqlCommand actors = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.igralci i INNER JOIN " +
                "filmi.igralci_filmi fi ON fi.igralec_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
            int i = 0;
            using (MySqlDataReader actor = actors.ExecuteReader())
            {
                while (actor.Read())
                {
                    if (i == 1)
                    {
                        igralci.Text = igralci.Text + ", " + actor["ime"].ToString()
                            + " " + actor["priimek"].ToString();
                    }
                    else
                    {
                        igralci.Text = "Igralci: " + actor["ime"].ToString() + " " + actor["priimek"].ToString();
                        i = 1;
                    }
                }
            }
            MySqlCommand writers = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.scenaristi i INNER JOIN " +
                "filmi.scenarsti_filmi fi ON fi.scenarist_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
            i = 0;
            using (MySqlDataReader writer = writers.ExecuteReader())
            {
                while (writer.Read())
                {
                    if (i == 1)
                    {
                        scenaristi.Text = scenaristi.Text + ", " + writer["ime"].ToString()
                            + " " + writer["priimek"].ToString();
                    }
                    else
                    {
                        scenaristi.Text = "Scenaristi: " + writer["ime"].ToString() + " " + writer["priimek"].ToString();
                        i = 1;
                    }
                }
            }
            MySqlCommand producers = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.producenti i INNER JOIN " +
                "filmi.producenti_filmi fi ON fi.producent_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
            i = 0;
            using (MySqlDataReader producer = producers.ExecuteReader())
            {
                while (producer.Read())
                {
                    if (i == 1)
                    {
                        producenti.Text = producenti.Text + ", " + producer["ime"].ToString()
                            + " " + producer["priimek"].ToString();
                    }
                    else
                    {
                        producenti.Text = "Producentii: " + producer["ime"].ToString() + " " + producer["priimek"].ToString();
                        i = 1;
                    }
                }
            }
            MySqlCommand directors = new MySqlCommand("SELECT i.ime,i.priimek FROM filmi.reziserji i INNER JOIN " +
                "filmi.reziserji_filmi fi ON fi.reziser_id=i.id INNER JOIN filmi.filmi f ON fi.film_id=f.id " +
                "WHERE fi.film_id=" + id + ";", connection);
            i = 0;
            using (MySqlDataReader director = directors.ExecuteReader())
            {
                while (director.Read())
                {
                    if (i == 1)
                    {
                        reziserji.Text = reziserji.Text + ", " + director["ime"].ToString()
                            + " " + director["priimek"].ToString();
                    }
                    else
                    {
                        reziserji.Text = "Režiserji: " + director["ime"].ToString() + " " + director["priimek"].ToString();
                        i = 1;
                    }
                }
            }
        }
    }
}
