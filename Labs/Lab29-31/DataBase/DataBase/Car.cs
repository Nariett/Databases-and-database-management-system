using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class Car
    {
        public Application Ex;
        public Workbook BookEx;
        public Worksheet PageEx;
        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataReader dr;

        public Car()
        {
            Ex = new Application();
            BookEx = Ex.Workbooks.Add();
            PageEx = (Worksheet)BookEx.Worksheets[1];
            cn = new SqlConnection(@"Data Source = DESKTOP-RES35B3\SQLSERVER;Initial Catalog = CarDataBase;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = cn;
            dr = null;
        }
    }
}
