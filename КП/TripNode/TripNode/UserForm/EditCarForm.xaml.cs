using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TripNode.Classes;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для EditCarForm.xaml
    /// </summary>
    public partial class EditCarForm : Window
    {
        private readonly Database dbManager;
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        public static List<Car> carList = new List<Car>();
        public event EventHandler UpdateValue;
        public EditCarForm()
        {
            InitializeComponent();
            dbManager = new Database(connectionString);
            carList = dbManager.GetAllCars();
            InitComboBox();
        }
        private void InitComboBox()
        {
            carList = dbManager.GetAllCars();
            comboBoxCar.Items.Clear();
            foreach (var car in carList)
            {
                comboBoxCar.Items.Add(car.name);
            }
        }

        private void DeleteCarButton_Click(object sender, RoutedEventArgs e)
        {
            if(comboBoxCar.SelectedIndex != -1)
            {
                Car car = carList[comboBoxCar.SelectedIndex];
                if (dbManager.DeleteCar(car))
                {
                    MessageBox.Show($"Автомобиль {car.name} удален","Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show($"Автомобиль {car.name} не удален", "Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                InitComboBox();
            }
            else
            {
                MessageBox.Show($"Выберите автомобиль, который хотите удалить", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void comboBoxCar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            comboBoxCar.SelectedIndex = -1;
        }
    }
}
