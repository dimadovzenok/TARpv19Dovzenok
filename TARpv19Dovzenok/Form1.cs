using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TARpv19Dovzenok
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\ruhm.mdf; Integrated Security = True");


        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            AndmeOtsing.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Nimi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tel.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Email.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ruhmadDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.ruhmadDataSet.Table);

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
