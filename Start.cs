using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace IntefataProiectBD
{

    public partial class Start : Form
    {
        OracleConnection c1 = ionescu_mihai_leonard_proiect_bd_262.Class1.GetDBConnection();
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afisari f2 = new Afisari();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificare f2 = new Modificare();
            f2.Show();
        }
    }
}
