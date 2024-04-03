using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TripNode.Classes;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для History.xaml
    /// </summary>

    public partial class History : Window
    {
        private readonly Database dbManager;
        private int idUser;

        public History(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
            dbManager = new Database(connectionString);
            List<TripInfo> trips = dbManager.GetTripsByUserId(idUser);
            dataGrid.ItemsSource = trips;
            dataGrid.AutoGenerateColumns = false;

            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Имя пользователя", Binding = new Binding("UserLogin") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Название машины", Binding = new Binding("CarName") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Точка А маршрута", Binding = new Binding("RoutePointA") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Точка B маршрута", Binding = new Binding("RoutePointB") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Пройденное расстояние", Binding = new Binding("Distance") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Расход топлива", Binding = new Binding("Consumption") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Средний расход", Binding = new Binding("AverageConsumption") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Дата поездки", Binding = new Binding("TripDate") { StringFormat = "dd.MM.yyyy" } });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Цена", Binding = new Binding("Price") });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Начало поездки", Binding = new Binding("TimeStart") { StringFormat = "HH.mm.ss" } });
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Окончание поездки", Binding = new Binding("TimeFinish") { StringFormat = "HH.mm.ss" } });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? startDate = DateOne.SelectedDate;
            DateTime? endDate = DateTwo.SelectedDate;

            if (startDate != null && endDate != null)
            {
                if (startDate <= endDate)
                {
                    // Обработка, если startDate меньше или равен endDate
                    List<TripInfo> data = dbManager.GetTripsBetweenDate(idUser, startDate.Value, endDate.Value);
                    dataGrid.ItemsSource = data;
                }
                else
                {
                    // Обработка, если startDate больше endDate
                    MessageBox.Show("Дата начала периода не может быть больше даты конца периода", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (startDate != null && endDate == null)
            {
                // Выполнить скрипт для работы с выбранной только первой датой startDate
                List<TripInfo> data = dbManager.GetTripsBetweenDate(idUser, startDate.Value, null);
                dataGrid.ItemsSource = data;
            }
            else if (startDate == null && endDate != null)
            {
                // Выполнить скрипт для работы с выбранной только второй датой endDate
                List<TripInfo> data = dbManager.GetTripsBetweenDate(idUser, null, endDate.Value);
                dataGrid.ItemsSource = data;
            }
            else if (startDate == null && endDate == null)
            {
                // Обе даты не заполнены
                List<TripInfo> dateFilterData = dbManager.GetTripsBetweenDate(idUser, null, null);
                dataGrid.ItemsSource = dateFilterData;
            }
        }
    }
}
