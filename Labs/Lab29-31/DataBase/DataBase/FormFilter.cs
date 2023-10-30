using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }
        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);

        }

        private void FormFilter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.carDataBaseDataSet.Client);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clientDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < clientDataGridView.RowCount - 1; j++)
                {
                    clientDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    clientDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < clientDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < clientDataGridView.RowCount - 1; j++)
                {
                    if (clientDataGridView.Rows[j].Cells[i].Value.ToString().Contains(textBox1.Text))
                    {
                        clientDataGridView.Rows[j].Cells[i].Style.BackColor = Color.AliceBlue;
                        clientDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn col = new System.Windows.Forms.DataGridViewColumn();
            switch (this.listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (this.radioButton1.Checked)
            {
                this.clientDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                this.clientDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.Filter = "Name= '" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
