using Microsoft.Win32;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TripNode.Classes;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для ReportForm.xaml
    /// </summary>
    public partial class ReportForm : Window
    {
        private readonly Database dbManager;
        int idUser;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";

        public ReportForm(int idUser)
        {
            InitializeComponent();
            dbManager = new Database(connectionString);
            this.idUser = idUser;
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
                    GenerateReport(data);
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
                GenerateReport(data);
            }
            else if (startDate == null && endDate != null)
            {
                // Выполнить скрипт для работы с выбранной только второй датой endDate
                List<TripInfo> data = dbManager.GetTripsBetweenDate(idUser, null, endDate.Value);
                GenerateReport(data);
            }
            else if (startDate == null && endDate == null)
            {
                // Обе даты не заполнены
                List<TripInfo> dateFilterData = dbManager.GetTripsBetweenDate(idUser, null, null);
                GenerateReport(dateFilterData);
            }
        }
        public void GenerateReport(List<TripInfo> trips)
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
                    document.InsertParagraph("Отчет о поездках").FontSize(20d).Bold().Alignment = Alignment.center;

                    // Создание переменной для хранения суммы расходов за месяц
                    decimal totalConsumption = 0;
                    int count = 1;
                    // Добавление информации о каждой поездке и вычисление суммы расходов за месяц
                    foreach (TripInfo trip in trips)
                    {
                        // Добавление информации о поездке
                        document.InsertParagraph($"Поекздка номер: {count}");
                        document.InsertParagraph($"Имя пользователя: {trip.UserLogin}");
                        document.InsertParagraph($"Название машины: {trip.CarName}");
                        document.InsertParagraph($"Точка A маршрута: {trip.RoutePointA}");
                        document.InsertParagraph($"Точка B маршрута: {trip.RoutePointB}");
                        document.InsertParagraph($"Пройденное расстояние: {trip.Distance}");
                        document.InsertParagraph($"Расход топлива: {trip.Consumption}");
                        document.InsertParagraph($"Средний расход: {trip.AverageConsumption}");
                        document.InsertParagraph($"Дата поездки: {trip.TripDate.ToString("dd.MM.yyyy")}");
                        document.InsertParagraph($"Цена: {trip.Price}");
                        document.InsertParagraph($"Начало поездки: {trip.TimeStart.ToString("HH.mm.ss")}");
                        document.InsertParagraph($"Окончание поездки: {trip.TimeFinish.ToString("HH.mm.ss")}");
                        document.InsertParagraph($"");
                        totalConsumption += trip.Price;
                        count++;
                    }

                    // Добавление строки с суммой расходов за месяц
                    document.InsertParagraph($"Общий расход за текущий период: {totalConsumption}");

                    document.Save();
                    MessageBox.Show("Документ сохранен");
                }
            }
        }
    }
}
