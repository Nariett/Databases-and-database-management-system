using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TripNode.Classes;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для RegForm.xaml
    /// </summary>
    public partial class RegForm : Window
    {
        private readonly Database dbManager;
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        public RegForm()
        {
            InitializeComponent();
            dbManager = new Database(connectionString);
        }
        private void RegButtonClick(object sender, RoutedEventArgs e)
        {
            // Проверяем валидность введенного логина и пароля
            if (TextBoxValid(textBoxLogin) & PasswordValid(textBoxPassword))
            {
                User user = new User(textBoxLogin.Text, textBoxPassword.Password);
                // Пытаемся добавить пользователя в базу данных
                if (dbManager.RegisterUser(user))
                {
                    // Выводим уведомление об успешном добавлении пользователя
                    MessageBox.Show("Пользователь добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close(); // Закрываем текущее окно регистрации
                }
                else
                {
                    // Выводим сообщение об ошибке, если логин или пароль уже заняты
                    MessageBox.Show("Данный логин или пароль занят. Повторите попытку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Выводим сообщение об ошибке, если введены некорректные данные
                MessageBox.Show("Пользователь не добавлен. Возможно ошибка в том, что:\n· Пустое поле\n· Длина поля меньше 3 символов\n· Использование запрещенных символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool TextBoxValid(TextBox text)
        {
            if (text.Text != "" & Regex.IsMatch(text.Text, @"^[a-zA-Zа-яА-Я\s\d\-_]+$") & text.Text.Length > 3)
            {
                text.BorderBrush = Brushes.Gray;
                return true;
            }
            else
            {
                text.BorderBrush = Brushes.Red;
                return false;
            }
        }
        private bool PasswordValid(PasswordBox text)
        {
            if (text.Password != "" & Regex.IsMatch(text.Password, @"^[a-zA-Zа-яА-Я\s\d\-_]+$") & text.Password.Length > 3 )
            {
                text.BorderBrush = Brushes.Gray;
                return true;
            }
            else
            {
                text.BorderBrush = Brushes.Red;
                return false;
            }
        }
    }
}
