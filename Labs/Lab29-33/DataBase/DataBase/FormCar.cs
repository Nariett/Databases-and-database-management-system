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
    public partial class FormCar : Form
    {
        public FormCar()
        {
            InitializeComponent();
        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);

        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Fine". При необходимости она может быть перемещена или удалена.
            this.fineTableAdapter.Fill(this.carDataBaseDataSet.Fine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.carDataBaseDataSet.Car);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            carBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);
        }
    }
}
