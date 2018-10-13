using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmi
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
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

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            OneMovie movie = new OneMovie();
            movie.Show();
        }
    }
}
