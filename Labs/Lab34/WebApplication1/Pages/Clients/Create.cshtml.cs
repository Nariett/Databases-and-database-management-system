using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication1.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            clientInfo.name = Request.Form["name"];
            clientInfo.surname = Request.Form["surname"];
            clientInfo.patronymic = Request.Form["patronymic"];
            clientInfo.addres = Request.Form["addres"];
            clientInfo.phone = Request.Form["phone"];

            if(clientInfo.name.Length==0|| clientInfo.surname.Length==0|| clientInfo.phone.Length==0|| clientInfo.addres.Length == 0 || clientInfo.patronymic.Length == 0)
            {
                errorMessage = "Error";
                return;
            }

            try
            {
                string connectionString = @"Data Source = DESKTOP-RES35B3\SQLSERVER;Initial Catalog = CarDataBase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql =    "INSERT INTO Client " +
                                    "(Name, Surname, Patronymic, Address, Phone_Number) VALUES " +
                                    "(@name, @surname, @patronymic, @addres, @phone);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", clientInfo.name);
                        command.Parameters.AddWithValue("@surname", clientInfo.surname);
                        command.Parameters.AddWithValue("@patronymic", clientInfo.patronymic);
                        command.Parameters.AddWithValue("@addres", clientInfo.addres);
                        command.Parameters.AddWithValue("@phone", clientInfo.phone);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }


            clientInfo.name = string.Empty;
            clientInfo.surname = string.Empty;
            clientInfo.patronymic = string.Empty;
            clientInfo.addres = string.Empty;
            clientInfo.phone = string.Empty;
            successMessage = "New client Added Correctly";

            Response.Redirect("/Clients/Index");
        }
    }
}
