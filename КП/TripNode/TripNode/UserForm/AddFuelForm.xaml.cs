using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using TripNode.Classes;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для AddFuelForm.xaml
    /// </summary>
    public partial class AddFuelForm : Window
    {
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        private readonly Database dbManager = new Database(connectionString);
        List<string> fuel = new List<string>() { "Бензин", "Дизельное топливо" };
        public event EventHandler UpdateValue;
        public AddFuelForm()
        {
            InitializeComponent();
            InitComboBox();
        }
        public void InitComboBox()
        {
            foreach(string fuelItem in fuel)
            {
                comboBoxFuel.Items.Add(fuelItem);
            }
        }
        private void ButtonAddRoute_Click(object sender, RoutedEventArgs e)
        {
            double fuelPrice;
            if(ValidValue() & IsValidDoubleInput(textBoxPrice,0,20, out fuelPrice))
            {
                string fuelType = comboBoxFuel.SelectedItem.ToString();
                string octanNumber = textBoxOctan.Text;
                Fuel fuel = new Fuel(fuelType, octanNumber, fuelPrice);
                if(dbManager.InsertFuel(fuel))
                {
                    MessageBox.Show($"Топливо было добавлено в систему.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show($"Топливо не было добавлено в систему. Автомобиль уже находится в системе.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

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
        private bool ValidValue()
        {
            if (TextBoxValid(textBoxPrice) & TextBoxValid(textBoxOctan) & ValidFuel())
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
            string selectedItem = IsValidComboBox(comboBoxFuel);
            if (selectedItem == "Бензин" || selectedItem == "Дизельное топливо")
            {
                if (comboBoxFuel.SelectedIndex != -1)
                {
                    return true;
                }
            }
            return false;
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
        private string FixStr(string input)
        {
            return input.Replace('.', ',');
        }
    }
}
