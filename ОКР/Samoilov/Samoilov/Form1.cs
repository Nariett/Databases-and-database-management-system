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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oKRDataSet.Writers". При необходимости она может быть перемещена или удалена.
            this.writersTableAdapter.Fill(this.oKRDataSet.Writers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }

        private void аToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA z = new FormA();
            z.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormB b = new FormB();
            b.Show(); 
        }

        private void сToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormС c = new FormС();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report p = new report();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Itog q = new Itog();
            q.Show();
        }
    }
}
