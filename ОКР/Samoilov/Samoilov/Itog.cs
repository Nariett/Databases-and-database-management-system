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

namespace Samoilov
{
    public partial class Itog : Form
    {
        public Itog()
        {
            InitializeComponent();
        }
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RES35B3\\SQLSERVER;Initial Catalog=OKR;Integrated Security=True");

        private void Itog_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT COUNT(*) AS NumberOfWriters FROM Writers;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string query = "SELECT TOP 1 Pseudonym, RealName, BirthYear FROM Writers ORDER BY BirthYear ASC;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string query = "SELECT TOP 1 Pseudonym, RealName, BirthYear FROM Writers ORDER BY BirthYear DESC;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView3.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
