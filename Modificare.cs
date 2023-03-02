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
    public partial class Modificare : Form
    {
        bool stergerej = false, cj = false;
        

        OracleDataAdapter oda;
        OracleCommandBuilder ocb;
        DataTable dt;
        OracleConnection c2 = ionescu_mihai_leonard_proiect_bd_262.Class1.GetDBConnection();
        int cj1;



        public Modificare()
        {
            InitializeComponent();
        }
        private void SAngajat_Load(object sender, EventArgs e)
        {
            OracleCommand command = c2.CreateCommand();
            c2.Open();
            
            command.CommandText = "select count(*) from JUDETE";
            cj1 = int.Parse(command.ExecuteScalar().ToString());
            c2.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from ANGAJATI", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonu_Click(object sender, EventArgs e)
        {
            ocb = new OracleCommandBuilder(oda);
            oda.Update(dt);

            OracleCommand command = c2.CreateCommand();
            c2.Open();
            int cj2;
            command.CommandText = "select count(*) from JUDETE";
            cj2 = int.Parse(command.ExecuteScalar().ToString());
            c2.Close();

            if(cj2 < cj1)
            {
                stergerej = true;
                cj1 = cj2; 
            }    

            if (stergerej == true && cj == true)
            {
                MessageBox.Show("O data ce ai sters acest judet toate locatiile care sunt din judetul acesta vor fi sterse\nDaca se vor sterge locatiile toate departamentele din acele locatii vor fi sterse\nDaca se vor sterge toate departamentele din acele locatii  toate joburile din aceste departamente vor fi sterse\nDar angajatii care au unul din job-urile sterse va trebuii sa fie modificati manual", "Stergere Judet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stergerej = false;
            }
                
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from MASINI", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from JOBURI", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from STOCK", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from SCULE", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from FURNIZORI", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cj = true;
            oda = new OracleDataAdapter("Select * from JUDETE", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from LOCATII", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from DEPARTAMENTE", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from ISTORIC_MASINI", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cj = false;
            oda = new OracleDataAdapter("Select * from ISTORIC_JOB", c2);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
