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
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RES35B3\\SQLSERVER;Initial Catalog=OKR;Integrated Security=True");

        private void FormB_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT RealName, Pseudonym FROM Writers WHERE RealName LIKE 'Иван %';";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
