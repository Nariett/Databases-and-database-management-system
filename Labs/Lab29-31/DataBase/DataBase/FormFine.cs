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
    public partial class FormFine : Form
    {
        public FormFine()
        {
            InitializeComponent();
        }

        private void fineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);

        }

        private void FormFine_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Fine". При необходимости она может быть перемещена или удалена.
            this.fineTableAdapter.Fill(this.carDataBaseDataSet.Fine);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fineBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fineBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fineBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fineBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fineBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fineBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);
        }
    }
}
