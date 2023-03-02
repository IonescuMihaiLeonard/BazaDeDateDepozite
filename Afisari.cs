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
    public partial class Afisari : Form
    {
        OracleConnection c2 = ionescu_mihai_leonard_proiect_bd_262.Class1.GetDBConnection();
        public Afisari()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from ANGAJATI", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from JOBURI", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from MASINI", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from DEPARTAMENTE", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from FURNIZORI", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from JUDETE", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from STOCK", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from ISTORIC_JOB", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from ISTORIC_MASINI", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from SCULE", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from LOCATII", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(textBox1.Text);
            
            OracleDataAdapter odp = new OracleDataAdapter("select DP.DENUMIRE,DP.ROL,SC.MARCA,SC.DENUMIRE,ST.STOCK,SC.PRET_VANZARE,(SC.PRET_VANZARE - SC.PRET_ACHIZITIE) AS PROFIT from SCULE SC, STOCK ST, DEPARTAMENTE DP where SC.SCULA_ID = ST.SCULA_ID and ST.DEPARTAMENT_ID = DP.DEPARTAMENT_ID and DP.DEPARTAMENT_ID = " + x + "AND (SC.PRET_VANZARE - SC.PRET_ACHIZITIE) > 0.15*SC.PRET_ACHIZITIE order by PROFIT ", c2);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
