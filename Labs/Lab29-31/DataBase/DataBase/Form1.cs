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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

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

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Ex.Visible = true;
            car.PageEx.Activate();
            car.PageEx.Range["a1", "f1"].MergeCells = true;
            car.PageEx.Range["a1", "f1"].Value = "Информация о автомобилях";
            car.PageEx.Range["a1", "f1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            car.PageEx.Range["a2"].Value = "ID";
            car.PageEx.Range["b2"].Value = "Марка";
            car.PageEx.Range["c2"].Value = "Модель";
            car.PageEx.Range["d2"].Value = "Номер";
            car.PageEx.Range["e2"].Value = "Тип";
            car.PageEx.Range["f2"].Value = "Год выпуска";
            car.PageEx.Range["a1", "f2"].Font.Bold = true;
            car.PageEx.Range["a1", "f2"].Font.Size = 16;
            car.PageEx.Range["a1", "f20"].Borders.LineStyle = XlLineStyle.xlContinuous;
            car.cmd.Connection = car.cn;
            car.cmd.CommandText = "SELECT ID_Car, Car_Brand, Car_Model, Car_Number, Car_Type, Year FROM Car";
            car.cn.Open();
            car.dr = car.cmd.ExecuteReader();
            int i = 3;
            while (car.dr.Read())
            {
                car.PageEx.Cells[i, 1] = car.dr["ID_Car"].ToString();
                car.PageEx.Cells[i, 2] = car.dr["Car_Brand"];
                car.PageEx.Cells[i, 3] = car.dr["Car_Model"];
                car.PageEx.Cells[i, 4] = car.dr["Car_Number"];
                car.PageEx.Cells[i, 5] = car.dr["Car_Type"].ToString();
                car.PageEx.Cells[i, 6] = car.dr["Year"].ToString();
                i += 1;
            }
            car.cn.Close();

        }
    }
}
