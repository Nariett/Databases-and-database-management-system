using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TripNode.Classes;
using TripNode.UserForm;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Xceed.Wpf.Toolkit;

namespace TripNode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        private readonly Database dbManager = new Database(connectionString);
        int idUser;
        List<Car> carList = new List<Car>();
        List<Route> routes = new List<Route>();
        List<FavoriteRoute> favoriteRoutes = new List<FavoriteRoute>();
        List<string> fuelList = new List<string>() { "Бензин", "Дизельное топливо" };
        Car selectCar = new Car();
        Route selectRoute = new Route();
        List<Fuel> fuelPrice = new List<Fuel>();
        public MainWindow(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            InitComboBox();
        }
        public void InitComboBox()
        {
            carList = dbManager.GetAllCars();
            routes = dbManager.GetAllRoutes();
            favoriteRoutes = dbManager.GetFavoriteRoutes(idUser);
            comboBoxCar.Items.Clear();
            foreach (var carItem in carList)
            {
                comboBoxCar.Items.Add(carItem.name);
            }
            comboBoxFuelType.Items.Clear();
            foreach (string fuelItem in fuelList)
            {
                comboBoxFuelType.Items.Add(fuelItem);
            }
            comboBoxRoute.Items.Clear();
            foreach (Route route in routes)
            {
                string itemText = $"{route.cityOne} - {route.cityTwo}";
                bool isFavorite = IsFavoriteRoute(route);

                // Создаем элемент с пользовательским форматированием
                TextBlock textBlock = new TextBlock();
                textBlock.Text = itemText;
                if (isFavorite)
                {
                    textBlock.Foreground = Brushes.Green;
                }

                comboBoxRoute.Items.Add(textBlock);
            }
        }
        private bool IsFavoriteRoute(Route route)
        {
            foreach (var favoriteRoute in favoriteRoutes)
            {
                if (favoriteRoute.PointA == route.cityOne && favoriteRoute.PointB == route.cityTwo)
                {
                    return true;
                }
            }
            return false;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBoxDistance.Clear();
            textBoxAverSpeed.Clear();
            textBoxTime.Clear();
            textBoxConsumption.Clear();
            textBoxPrice.Clear();
            textBoxFuelPrice.Clear();
            textBoxUsedFuel.Clear();
            textBoxDistance.BorderBrush = Brushes.Gray;
            textBoxFuelPrice.BorderBrush = Brushes.Gray;
            textBoxConsumption.BorderBrush = Brushes.Gray;
            comboBoxFuelType.SelectedIndex = -1;
            comboBoxCar.SelectedIndex = -1;
            comboBoxRoute.SelectedIndex = -1;
        }

        private void comboBoxCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxCar.SelectedIndex != -1)
            {
                selectCar = dbManager.GetCarData(comboBoxCar.Items[comboBoxCar.SelectedIndex].ToString());
                comboBoxFuelType.SelectedIndex = fuelList.IndexOf(selectCar.fuel);
                textBoxConsumption.Text = selectCar.fuelConsumptionGeneral.ToString();
                fuelPrice = dbManager.GetFuelList(comboBoxFuelType.SelectedItem.ToString());

                textBoxFuelPrice.Text = fuelPrice.FirstOrDefault(fuel => fuel.FuelType == comboBoxFuelType.SelectedItem.ToString() && fuel.OctaneNumber == selectCar.fuelOctan)?.FuelPrice.ToString() ?? "0";

                comboBoxFuelType.IsEnabled = false;
                textBoxConsumption.IsEnabled = false;
                textBoxFuelPrice.IsEnabled = false;
            }
            else
            {
                comboBoxFuelType.SelectedIndex = -1;
                comboBoxFuelType.IsEnabled = false;
                textBoxConsumption.IsEnabled = false;
                textBoxFuelPrice.IsEnabled = false;
                textBoxFuelPrice.Clear();
                textBoxConsumption.Clear();
            }
        }

        private void comboBoxCar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            comboBoxCar.SelectedIndex = -1;
            selectCar = null;
        }

        private void comboBoxPointOne_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            comboBoxRoute.SelectedIndex = -1;
            selectRoute = null;
        }

        private void comboBoxPointOne_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxRoute.SelectedIndex != -1)
            {
                textBoxDistance.Text = routes[comboBoxRoute.SelectedIndex].distance.ToString();
                textBoxDistance.IsEnabled = false;
                selectRoute = routes[comboBoxRoute.SelectedIndex];
            }
            else
            {
                textBoxDistance.IsEnabled = false;
            }
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Проверяем валидность введенных значений
            if (ValidValue())
            {
                // Получаем значения из комбо-боксов
                string car = SetValue(comboBoxCar);
                string route = SetValue(comboBoxRoute);
                // Получаем выбранный тип топлива
                string fuelType = comboBoxFuelType.SelectedItem.ToString();
                // Получаем числовые значения из текстовых полей
                double distance = Convert.ToDouble(this.textBoxDistance.Text);
                double fuelPrice = Convert.ToDouble(this.textBoxFuelPrice.Text);
                double consumption = Convert.ToDouble(this.textBoxConsumption.Text);
                double averageSpeed = Convert.ToDouble(this.textBoxAverSpeed.Text);
                int people = Convert.ToInt32(this.textBoxPeople.Text);
                // Проверяем условие и увеличиваем расход топлива, если средняя скорость превышает 140 км/ч
                if (averageSpeed > 140 && car == "Неизвестно")
                {
                    consumption += 1;
                }
                // Выполняем необходимые расчеты
                double usedFuel = Math.Round((distance * consumption) / 100.0,2);
                double result = distance / averageSpeed;
                double fullPrice = Math.Round((distance / 100) * fuelPrice * consumption, 2);
                // Получаем выбранную дату из DatePicker
                DateTime dateOne = (DateTime)DataPickerFirstData.SelectedDate;
                DateTime? selectedTime = timePicker.Value;
                DateTime startDate;
                string date;
                date = dateOne.ToString("dd.MM.yyyy");
                if (selectedTime.HasValue)
                {
                    startDate = dateOne.Date + selectedTime.Value.TimeOfDay;
                }
                else
                {
                    System.Windows.MessageBox.Show("Выберите время отправки", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                TimeSpan timeSpan = TimeSpan.FromHours(result);
                DateTime endTime = startDate;
                endTime = endTime.Add(timeSpan);
                // Заполняем текстовые поля с расчетами
                textBoxUsedFuel.Text = usedFuel.ToString();
                textBoxUsedFuel.BorderBrush = Brushes.Green;
                textBoxTime.Text = Math.Round(result, 2).ToString();
                textBoxTime.BorderBrush = Brushes.Green;
                textBoxPrice.Text = fullPrice.ToString();
                textBoxPrice.BorderBrush = Brushes.Green;
                // Получаем идентификаторы пользователя, автомобиля и маршрута из базы данных
                Car selectCar = carList[comboBoxCar.SelectedIndex];
                int idCar = dbManager.GetIdCar(dbManager.GetCarData(selectCar.name));
                Route selectRoute = routes[comboBoxRoute.SelectedIndex];
                int idRoute = dbManager.GetIdRoute(selectRoute);
                // Создаем объект поездки
                Trips trip = new Trips(idUser, idCar, idRoute, distance, usedFuel, selectCar.fuelConsumptionGeneral, date, fullPrice, startDate, endTime);

                // Добавляем поездку в базу данных
                if (dbManager.InsertTrip(trip))
                {
                    // Выводим сообщение с подтверждением
                    var res = System.Windows.MessageBox.Show("Хотите сохранить данную поездку?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    // Проверка выбора пользователя
                    if (res == MessageBoxResult.Yes)
                    {
                        // Если пользователь выбрал "Да", вызываем функцию для создания документа
                        GenerateReport(trip,selectCar,selectRoute);
                    }
                }
                else
                {
                    // Выводим сообщение об ошибке, если поездка не была оформлена
                    System.Windows.MessageBox.Show("Поездка не оформлена. Так как данный автомобиль занят другим пользователем на этот день", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Заполните все поля и повторите попытку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidValue()
        {
            double distance, averageSpeed, consumption, fuelPrice;
            if (IsValidDoubleInput(textBoxDistance, 0, 10000, out distance) &
                IsValidDoubleInput(textBoxAverSpeed, 0, (selectCar == null) ? selectCar.maxSpeed : 300, out averageSpeed) &
                IsValidDoubleInput(textBoxConsumption, 0, 100, out consumption) &
                IsValidDoubleInput(textBoxFuelPrice, 0, 1000, out fuelPrice) &
                IsValidPlacesInput(textBoxPeople) &
                IsValidDataInput(DataPickerFirstData))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string SetValue(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex != -1)
            {
                return comboBox.SelectedItem.ToString();
            }
            else { return "Неизвестно"; }
        }

        private bool IsValidPlacesInput(TextBox textBoxPeople)
        {
            if (comboBoxCar.SelectedIndex != -1)
            {
                if (int.TryParse(textBoxPeople.Text, out int people) && people > 0 && people <= selectCar.seatingCapacity)
                {
                    textBoxPeople.BorderBrush = Brushes.Gray;
                    return true;
                }
                textBoxPeople.BorderBrush = Brushes.Red;
                return false;
            }
            textBoxPeople.BorderBrush = Brushes.Gray;
            return true;
        }

        private bool IsValidDoubleInput(TextBox box, int min, int max, out double value)
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
        private string FixStr(string input)
        {
            return input.Replace('.', ',');
        }
        private bool IsValidDataInput(DatePicker picker)
        {
            if (picker.SelectedDate.HasValue & picker.SelectedDate >= DateTime.Now.Date)
            {
                picker.BorderBrush = Brushes.Gray;
                return true;
            }
            else
            {
                picker.BorderBrush = Brushes.Red;
                return false;
            }
        }

        private void MenuItem_ClickHistory(object sender, RoutedEventArgs e)
        {
            UserForm.History history = new UserForm.History(idUser);
            history.ShowDialog();
        }


        private void MenuItem_ClickCar(object sender, RoutedEventArgs e)
        {
            UserForm.AddCarForm carForm = new UserForm.AddCarForm();
            carForm.UpdateValue += EditRoute_UpdateValue;
            carForm.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            UserForm.AddRouteForm newRoute = new UserForm.AddRouteForm();
            newRoute.UpdateValue += EditRoute_UpdateValue;
            newRoute.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            UserForm.EditRouteForm editRoute = new UserForm.EditRouteForm(idUser);
            editRoute.UpdateValue += EditRoute_UpdateValue;
            editRoute.ShowDialog();
        }
        private void EditRoute_UpdateValue(object sender, EventArgs e)
        {
            InitComboBox();
        }
        private void MenuItem_ClickCar2(object sender, RoutedEventArgs e)
        {
            UserForm.EditCarForm editCarForm = new UserForm.EditCarForm();
            editCarForm.UpdateValue += EditRoute_UpdateValue;
            editCarForm.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            UserForm.ReportForm report = new UserForm.ReportForm(idUser);
            report.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            UserForm.AddFuelForm addForm = new UserForm.AddFuelForm();
            addForm.UpdateValue += EditRoute_UpdateValue;
            addForm.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            UserForm.EditFuelForm editFuel = new UserForm.EditFuelForm();
            editFuel.UpdateValue += EditRoute_UpdateValue;
            editFuel.ShowDialog();
        }
        private void GenerateReport(Trips trip, Car car, Route route)
        {
            // Создание диалогового окна сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Документ Word (*.docx)|*.docx";
            saveFileDialog.FileName = "TripReport";

            // Если пользователь выбрал место сохранения файла и нажал "Сохранить"
            if (saveFileDialog.ShowDialog() == true)
            {
                // Создание документа Word
                using (DocX document = DocX.Create(saveFileDialog.FileName))
                {
                    // Добавление заголовка
                    document.InsertParagraph("Отчет о поездке").FontSize(20d).Bold().Alignment = Alignment.center;

                    // Добавление информации о поездке
                    document.InsertParagraph($"Название машины: {car.name}");
                    document.InsertParagraph($"Точка A маршрута: {route.cityOne}");
                    document.InsertParagraph($"Точка B маршрута: {route.cityTwo}");
                    document.InsertParagraph($"Пройденное расстояние: {route.distance}");
                    document.InsertParagraph($"Расход топлива: {trip.consumption}");
                    document.InsertParagraph($"Средний расход: {trip.averageConsumption}");
                    document.InsertParagraph($"Дата поездки: {trip.date}");
                    document.InsertParagraph($"Цена: {trip.price}");
                    document.InsertParagraph($"Начало поездки: {trip.timeStart.ToString("HH.mm.ss")}");
                    document.InsertParagraph($"Окончание поездки: {trip.timeFinish.ToString("HH.mm.ss")}");

                    document.Save();
                    System.Windows.MessageBox.Show("Документ сохранен");
                }
            }
        }
    }
}
