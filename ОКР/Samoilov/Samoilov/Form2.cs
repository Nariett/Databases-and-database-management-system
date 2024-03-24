using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samoilov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oKRDataSet.Writers". При необходимости она может быть перемещена или удалена.
            this.writersTableAdapter.Fill(this.oKRDataSet.Writers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writersBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            writersBindingSource.MoveNext();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            writersBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            writersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.writersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oKRDataSet);
        }
    }
}
