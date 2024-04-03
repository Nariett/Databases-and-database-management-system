﻿using System;
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
    /// Логика взаимодействия для AddRouteForm.xaml
    /// </summary>
    public partial class AddRouteForm : Window
    {
        private readonly Database dbManager;
        public readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        public event EventHandler UpdateValue;
        public AddRouteForm()
        {
            InitializeComponent();
            dbManager = new Database(connectionString);
        }

        private void ButtonAddRoute_Click(object sender, RoutedEventArgs e)//добавление маршурта
        {
            string pointA = textBoxPointA.Text.TrimEnd();
            string pointB = textBoxPointB.Text.TrimEnd();
            double distance = 0;
            bool IsValidValue = IsValidDoubleInput(textBoxDistance, 0, 40000, out distance);
            if ((TextBoxValid(textBoxPointA) & TextBoxValid(textBoxPointB) & IsValidValue) & (pointA != pointB))
            {
                Route route = new Route(pointA, pointB, distance);
                if (dbManager.InsertRoute(route))
                {
                    MessageBox.Show($"Маршрут {pointA} - {pointB} добавлен в систему.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show($"Маршрут {pointA} - {pointB} не добавлен, так как уже есть в системе.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка в маршруте, проверьте маршрут и повторите попытку.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool IsValidDoubleInput(TextBox box, int min, int max, out double value)//проверка вещественных значений 
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
        private bool TextBoxValid(TextBox text)//проверка кооректносоти данных в textBox
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
        private string FixStr(string input)//замена . на ,
        {
            return input.Replace('.', ',');
        }
    }
}
