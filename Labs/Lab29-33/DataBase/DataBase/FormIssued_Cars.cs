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
    public partial class FormIssued_Cars : Form
    {
        public FormIssued_Cars()
        {
            InitializeComponent();
        }

        private void issued_CarsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issued_CarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);

        }

        private void FormIssued_Cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Issued_Cars". При необходимости она может быть перемещена или удалена.
            this.issued_CarsTableAdapter.Fill(this.carDataBaseDataSet.Issued_Cars);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            issued_CarsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            issued_CarsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            issued_CarsBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            issued_CarsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            issued_CarsBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            issued_CarsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issued_CarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);
        }
    }
}
