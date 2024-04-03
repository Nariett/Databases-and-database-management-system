using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для AddCarForm.xaml
    /// </summary>
    public partial class AddCarForm : Window
    {
        private readonly Database dbManager;
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        public event EventHandler UpdateValue;
        public AddCarForm()
        {
            InitializeComponent();
            InitComboBox();
            dbManager = new Database(connectionString);
        }
        private List<string> Fuel = new List<string>() { "Бензин", "Дизельное топливо" };
        private List<string> CarType = new List<string>() { "Седан", "Купе", "Хэтчбек", "Универсал", "Внедорожник", "Кроссовер", "Кабриолет", "Лифтбек", "Фургон", "Минивэн", "Пикап" };
        public void InitComboBox()
        {
            comboBoxFuelType.ItemsSource = Fuel;
            comboBoxCarType.ItemsSource = CarType;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidValue())
            {
                string name = this.textBoxName.Text;
                int year = Convert.ToInt32(this.textBoxYear.Text);
                string typeCar = this.comboBoxCarType.SelectedItem.ToString();
                int seatingCapacity = Convert.ToInt32(this.textBoxPlace.Text);
                int maxSpeed = Convert.ToInt32(this.textBoxMaxSpeed.Text);
                string fuel = this.comboBoxFuelType.SelectedItem.ToString();
                string fuelType;
                if (fuel == "Дизельное топливо" & comboBoxOctan.SelectedIndex == 0)
                {
                    fuelType = "";
                }
                else
                {
                    fuelType = comboBoxOctan.SelectedItem.ToString();
                }
                double fuelConsumptionGeneral = DoubleNull(textBoxFuelConsumptionGeneral);
                Car car = new Car(name, year, typeCar, maxSpeed, seatingCapacity, fuel, fuelType, fuelConsumptionGeneral);
                if (dbManager.InsertCar(car))
                {
                    MessageBox.Show($"Автомобиль: {name} был добавлен в систему.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show($"Автомобиль: {name} не был добавлен в систему. Автомобиль уже находится в системе.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void comboBoxFuelType_SelectionChanged(object sender, SelectionChangedEventArgs e) // обработчик изменение значения в comboBox
        {
            string selectedItem = comboBoxFuelType.SelectedItem.ToString();
            if (selectedItem == "Бензин")
            {
                List<Fuel> fuelOctan = dbManager.GetFuelList("Бензин");
                foreach(var fuel in fuelOctan)
                {
                    comboBoxOctan.Items.Add(fuel.OctaneNumber);
                }
            }
            else if (selectedItem == "Дизельное топливо")
            {
                List<Fuel> fuelOctan = dbManager.GetFuelList("Дизельное топливо");
                foreach (var fuel in fuelOctan)
                {
                    comboBoxOctan.Items.Add(fuel.OctaneNumber);
                }
            }
            comboBoxOctan.SelectedIndex = 1;
        }
        private bool ValidValue()
        {
            if (TextBoxValid(textBoxName) & ValidFuel() & СonsumptionСheck() & LogicCheck())
            {
                return true;
            }
            return false;
        }
        private bool TextBoxValid(TextBox text)// проверка значения в textBox 
        {
            if (text.Text == "")
            {
                text.BorderBrush = Brushes.Red;
                return false;
            }
            else
            {
                text.BorderBrush = Brushes.Gray;
                return true;
            }
        }
        private bool ValidFuel() // проверка корректности выбора топлива
        {
            string selectedItem = IsValidComboBox(comboBoxFuelType);
            if (selectedItem == "Бензин" || selectedItem == "Дизельное топливо")
            {
                if (comboBoxFuelType.SelectedIndex != -1 && textBoxFuelConsumptionGeneral.Text != "")
                {
                    return true;
                }
            }
            return false;
        }
        private bool СonsumptionСheck()
        {
            string selectedItem = IsValidComboBox(comboBoxFuelType);
            double ConsumptionGeneral;
            bool isNumericOne = IsValidDoubleInput(textBoxFuelConsumptionGeneral, 0, 100, out ConsumptionGeneral);
            if (selectedItem == "Бензин" || selectedItem == "Дизельное топливо")
            {
                if (isNumericOne)
                {
                    textBoxFuelConsumptionGeneral.BorderBrush = Brushes.Gray;
                    return true;
                }
            }
            return false;
        }
        private bool LogicCheck() // логическая проверка значений в полях 
        {
            string selectedItem = IsValidComboBox(comboBoxCarType);
            int year, speed, place, minSeats = 2, maxSeats = 5;
            bool IsYear, IsSpeed, IsSeats;
            IsYear = IsValidIntInput(textBoxYear, 1980, 2024, out year);
            IsSpeed = IsValidIntInput(textBoxMaxSpeed, 0, 500, out speed);
            IsSeats = IsValidIntInput(textBoxPlace, 0, 11, out place);
            if (selectedItem == "Фургон")
            {
                minSeats = 2;
                maxSeats = 10;
            }
            else if (selectedItem == "Универсал" || selectedItem == "Внедорожник" || selectedItem == "Кроссовер" || selectedItem == "Минивэн")
            {
                minSeats = 5;
                maxSeats = 8;
            }
            if (place >= minSeats && place <= maxSeats)
            {
                textBoxPlace.BorderBrush = Brushes.Gray;
                if (IsYear && IsSpeed && IsSeats)
                {
                    comboBoxCarType.BorderBrush = Brushes.Gray;
                    return true;
                }
                return false;
            }
            else
            {
                if (selectedItem == "Ошибка")
                {
                    textBoxPlace.BorderBrush = Brushes.Red;
                    return false;
                }
                MessageBox.Show($"Ошибка количества мест. Требуется от {minSeats} до {maxSeats} мест для автомобиля типа {selectedItem}");
                textBoxPlace.BorderBrush = Brushes.Red;
                return false;
            }
        }
        private bool IsValidIntInput(TextBox text, int min, int max, out int value) // проверка корректности введенных целочисленных значений 
        {
            if (text.Text == "")
            {
                value = 0;
                text.BorderBrush = Brushes.Red; // смена цвета границы элемента
                return false;
            }
            bool isNumeric = int.TryParse(text.Text, out value);
            if (isNumeric)
            {
                if (value > min && value < max)
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
            else
            {
                text.BorderBrush = Brushes.Red;
                return false;
            }
        }
        private bool IsValidDoubleInput(TextBox box, int min, int max, out double value)// проверка корректности введенных вещественное  значений 
        {
            if (box.Text == "")
            {
                value = 0;
                box.BorderBrush = Brushes.Red;
                return false;
            }

            bool isNumeric = double.TryParse(FixStr(box.Text), out value);
            if (isNumeric)
            {
                if (value > min && value < max)
                {
                    box.BorderBrush = Brushes.Gray;
                    return true;
                }
                else
                {
                    box.BorderBrush = Brushes.Red;
                    return false;
                }
            }
            else
            {
                box.BorderBrush = Brushes.Red;
                return false;
            }
        }
        private string IsValidComboBox(ComboBox box)// проверка корректности выбора значения в comboBox
        {
            if (box.SelectedIndex == -1)
            {
                return "Ошибка";
            }
            else
            {
                return box.SelectedItem.ToString();
            }
        }

        private string FixStr(string input)
        {
            return input.Replace('.', ',');
        }
        private double DoubleNull(TextBox text)
        {
            if (text.Text != "")
            {
                return Convert.ToDouble(FixStr(text.Text));
            }
            else
            {
                return 0;
            }
        }
    }
}
