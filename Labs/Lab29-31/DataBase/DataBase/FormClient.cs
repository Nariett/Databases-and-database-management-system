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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataBaseDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.carDataBaseDataSet.Client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataBaseDataSet);
        }
    }
}
