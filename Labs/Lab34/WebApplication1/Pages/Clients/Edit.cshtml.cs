using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication1.Pages.Clients
{
    public class EditModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public string errorMessage = string.Empty;
        public string successMessage = string.Empty;
        public void OnGet()
        {
            string id = Request.Query["id"];

            try
            {
                string connectionString = @"Data Source = DESKTOP-RES35B3\SQLSERVER;Initial Catalog = CarDataBase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Client WHERE ID_Client=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clientInfo.id = ""+ reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.surname = reader.GetString(2);
                                clientInfo.patronymic = reader.GetString(3);
                                clientInfo.addres = reader.GetString(4);
                                clientInfo.phone = reader.GetString(5);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void OnPost()
        {
            clientInfo.id = Request.Form["id"];
            clientInfo.name = Request.Form["name"];
            clientInfo.surname = Request.Form["surname"];
            clientInfo.patronymic = Request.Form["patronymic"];
            clientInfo.phone = Request.Form["phone"];
            clientInfo.addres = Request.Form["addres"];

            if (clientInfo.name.Length == 0 || clientInfo.surname.Length == 0 || clientInfo.patronymic.Length == 0 || clientInfo.phone.Length == 0 || clientInfo.addres.Length == 0)
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
                    string sql = "UPDATE Client " +
                                 "SET Name = @name, Surname = @surname, Patronymic = @patronymic, Address = @addres, Phone_Number = @phone " +
                                 "WHERE ID_Client=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        command.Parameters.AddWithValue("@name", clientInfo.name);
                        command.Parameters.AddWithValue("@surname", clientInfo.surname);
                        command.Parameters.AddWithValue("@patronymic", clientInfo.patronymic);
                        command.Parameters.AddWithValue("@addres", clientInfo.addres);
                        command.Parameters.AddWithValue("@phone", clientInfo.phone);
                        command.Parameters.AddWithValue("@id", clientInfo.id);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw; // Handle exceptions properly in your application
            }
            Response.Redirect("/Clients/Index");
        }

    }
}
