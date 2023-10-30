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
    public partial class FormDiscounts : Form
    {
        public FormDiscounts()
        {
            InitializeComponent();
        }

        private void discountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);

        }

        private void FormDiscounts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.carDataBaseDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Discounts". При необходимости она может быть перемещена или удалена.
            this.discountsTableAdapter.Fill(this.carDataBaseDataSet.Discounts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            discountsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            discountsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            discountsBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            discountsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            discountsBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            discountsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);
        }
    }
}
