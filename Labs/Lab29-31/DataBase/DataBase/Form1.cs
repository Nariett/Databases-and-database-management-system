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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCar formCar = new FormCar();
            formCar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDiscounts formDiscounts = new FormDiscounts();
            formDiscounts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormFine formFine = new FormFine();
            formFine.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FormIssued_Cars form = new FormIssued_Cars();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFilter formFilter = new FormFilter();
            formFilter.Show();
        }
    }
}
