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
    /// Логика взаимодействия для EditFuelForm.xaml
    /// </summary>
    public partial class EditFuelForm : Window
    {
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        private readonly Database dbManager = new Database(connectionString); 
        public static List<Fuel> fuelList = new List<Fuel>();
        List<string> fuel = new List<string>() { "Бензин", "Дизельное топливо" };
        public event EventHandler UpdateValue;
        public EditFuelForm()
        {
            InitializeComponent();
            InitComboBox();
        }
        private void InitComboBox()
        {
            comboBoxFuel.Items.Clear();
            foreach (string fuelItem in fuel)
            {
                comboBoxFuel.Items.Add(fuelItem);
            }
            comboBoxOctane.Items.Clear();
            textBoxPrice.Text = "";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(comboBoxFuel.SelectedIndex != -1 && comboBoxOctane.SelectedIndex != -1)
            {
                string fuel = comboBoxFuel.SelectedItem.ToString();
                string octaneNumber = comboBoxOctane.SelectedItem.ToString();
                if (dbManager.DeleteFuel(fuel, octaneNumber))
                {

                    MessageBox.Show($"Топливо {fuel} - {octaneNumber} удалено", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                    InitComboBox();
                }
                else
                {
                    MessageBox.Show($"Топливо {fuel} - {octaneNumber} не удалено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            else
            {
                MessageBox.Show($"Выберите топливо для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditFuelButton_Click(object sender, RoutedEventArgs e)
        {
            double fuelPrice;
            if (comboBoxFuel.SelectedIndex != -1 && comboBoxOctane.SelectedIndex != -1 & IsValidDoubleInput(textBoxPrice, 0, 20, out fuelPrice))
            {
                string fuel = comboBoxFuel.SelectedItem.ToString();
                string octaneNumber = comboBoxOctane.SelectedItem.ToString();
                Fuel newFuel = new Fuel(fuel, octaneNumber, fuelPrice);
                if (dbManager.UpdateFuelPrice(newFuel))
                {

                    MessageBox.Show($"Топливо {fuel} - {octaneNumber} обновлено", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                    InitComboBox();
                }
                else
                {
                    MessageBox.Show($"Топливо {fuel} - {octaneNumber} не обновлено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show($"Введите корректные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
        private string FixStr(string input)//замена . на ,
        {
            return input.Replace('.', ',');
        }
        private void comboBoxFuel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBoxFuel.SelectedIndex != -1)
            {
                fuelList = dbManager.GetFuelList(comboBoxFuel.SelectedItem.ToString());
                foreach( Fuel fuel in fuelList)
                {
                    comboBoxOctane.Items.Add(fuel.OctaneNumber);
                }
            }
            else
            {
                comboBoxOctane.SelectedIndex = -1;
            }
        }

        private void comboBoxOctane_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBoxOctane.SelectedIndex != -1)
            {
                textBoxPrice.Text = fuelList[comboBoxFuel.SelectedIndex].FuelPrice.ToString();
            }
            else
            {
                textBoxPrice.Text = "";
            }
        }

    }
}
