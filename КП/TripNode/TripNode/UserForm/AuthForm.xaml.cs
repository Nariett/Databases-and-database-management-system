using System.Windows;
using TripNode.Classes;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для AuthForm.xaml
    /// </summary>
    public partial class AuthForm : Window
    {
        private readonly Database dbManager;
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";

        public AuthForm()
        {
            InitializeComponent();
            dbManager = new Database(connectionString);
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            UserForm.RegForm regForm = new UserForm.RegForm();
            regForm.ShowDialog();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Password != "")
            {
                if (dbManager.CheckUser(textBoxLogin.Text, textBoxPassword.Password))
                {
                    MainWindow userForm = new MainWindow(dbManager.GetIdUser(textBoxLogin.Text,textBoxPassword.Password));
                    userForm.ShowDialog();                    
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля и повторите попытку!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
