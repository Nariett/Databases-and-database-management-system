using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TripNode.Classes;

namespace TripNode.UserForm
{
    /// <summary>
    /// Логика взаимодействия для EditRouteForm.xaml
    /// </summary>
    public partial class EditRouteForm : Window
    {
        int IdUser;
        private readonly Database dbManager;
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarDB.mdf;Integrated Security=True;";
        private static List<Route> routeList = new List<Route>();
        public event EventHandler UpdateValue;
        public EditRouteForm(int idUser)
        {
            InitializeComponent();
            dbManager = new Database(connectionString);
            routeList = dbManager.GetAllRoutes();
            InitComboBox();
            IdUser = idUser;
        }

        private void InitComboBox()
        {
            routeList = dbManager.GetAllRoutes();
            comboBoxRoute.Items.Clear();
            foreach (var route in routeList)
            {
                comboBoxRoute.Items.Add($"{route.cityOne} - {route.cityTwo}");
            }
        }

        private void EditRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if(comboBoxRoute.SelectedIndex != -1)
            {

                if (Convert.ToDouble(textBoxDistance.Text) > 0 && Convert.ToDouble(textBoxDistance.Text) < 10000 && comboBoxRoute.SelectedIndex != 1)
                {
                    Route newRoute = routeList[comboBoxRoute.SelectedIndex];
                    newRoute.distance = Convert.ToDouble(textBoxDistance.Text);
                    if (dbManager.UpdateRoute(newRoute))
                    {
                        MessageBox.Show($"Маршрут {newRoute.cityOne} - {newRoute.cityTwo} обновлен","Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        UpdateValue?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show($"Маршрут {newRoute.cityOne} - {newRoute.cityTwo} не обновлен","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Ошибка, проверьте введенные данные","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                InitComboBox();
            }
            else
            {
                MessageBox.Show("Выберите маршрут для редактирования", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxRoute.SelectedIndex != -1)
            {
                Route route = routeList[comboBoxRoute.SelectedIndex];
                string pointA = route.cityOne;
                string pointB = route.cityTwo;
                int idRoute = dbManager.GetIdRoute(pointA, pointB);
                bool favoriteCheck = dbManager.DeleteFavoriteRoute(IdUser, idRoute);
                if (dbManager.DeleteRoute(route))
                {
                    if (favoriteCheck)
                    {
                        MessageBox.Show($"Маршрут {route.cityOne} - {route.cityTwo} удален и так же удалени из избранных", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        UpdateValue?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show($"Маршрут {route.cityOne} - {route.cityTwo} удален", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        UpdateValue?.Invoke(this, EventArgs.Empty);
                    }
                }
                else
                {
                    MessageBox.Show($"Маршрут {route.cityOne} - {route.cityTwo} не удален", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                InitComboBox();
            }
            else
            {
                MessageBox.Show("Выберите маршрут для удалени", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void comboBoxPointOne_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            comboBoxRoute.SelectedIndex = -1;
        }

        private void comboBoxRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxRoute.SelectedIndex != -1)
            {
                int selectedIndex = comboBoxRoute.SelectedIndex;
                textBoxDistance.Text = routeList[selectedIndex].distance.ToString();
            }
            else
            {
                textBoxDistance.Text = string.Empty;
            }
        }

        private void FavoriteRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if(comboBoxRoute.SelectedIndex != -1)
            {
                Route route = routeList[comboBoxRoute.SelectedIndex];
                string pointA = route.cityOne;
                string pointB = route.cityTwo;
                int idRoute = dbManager.GetIdRoute(pointA, pointB);
                if(dbManager.InsertFavoriteRoute(IdUser, idRoute))
                {
                    MessageBox.Show("Маршрут добавлен в избранное","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Маршрут не добавлен в избранное","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите маршрут для добавления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void DeleteFavoriteRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxRoute.SelectedIndex != -1)
            {
                Route route = routeList[comboBoxRoute.SelectedIndex];
                string pointA = route.cityOne;
                string pointB = route.cityTwo;
                int idRoute = dbManager.GetIdRoute(pointA, pointB);
                if (dbManager.DeleteFavoriteRoute(IdUser, idRoute))
                {
                    MessageBox.Show("Маршрут удален из избранного", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateValue?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Маршрут не удален из избранного", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите маршрут для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
