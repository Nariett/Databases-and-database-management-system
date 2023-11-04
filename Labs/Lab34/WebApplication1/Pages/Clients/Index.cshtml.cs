using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication1.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();
        public string successMessage = "";
        public void OnGet()
        {
            try
            {
                string connection = @"Data Source = DESKTOP-RES35B3\SQLSERVER;Initial Catalog = CarDataBase;Integrated Security=True";

                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string sqlQuery = "SELECT * FROM Client";
                    using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = reader.GetInt32(0).ToString();
                                clientInfo.name = reader.GetString(1);
                                clientInfo.surname = reader.GetString(2);
                                clientInfo.patronymic = reader.GetString(3);
                                clientInfo.addres = reader.GetString(4);
                                clientInfo.phone = reader.GetString(5);
                                listClients.Add(clientInfo);
                            }

                        }
                    }
                    successMessage = listClients[0].name;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class ClientInfo
    {
        public string id;
        public string name;
        public string surname;
        public string patronymic;
        public string addres;
        public string phone;
    }
}
