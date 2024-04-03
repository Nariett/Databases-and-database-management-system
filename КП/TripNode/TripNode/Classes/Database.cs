using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using System.Windows;

namespace TripNode.Classes
{


    class Database
    {
        private readonly string connectionString;

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool RegisterUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка наличия пользователя с таким логином
                using (var checkCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Login = @Login", connection))
                {
                    checkCommand.Parameters.AddWithValue("@Login", user.login);
                    int existingUsersCount = (int)checkCommand.ExecuteScalar();

                    if (existingUsersCount > 0)
                    {
                        // Пользователь с таким логином уже существует
                        return false;
                    }
                }

                // Если пользователь с таким логином не найден, выполняем вставку
                using (var insertCommand = new SqlCommand("INSERT INTO Users (Login, Password) VALUES (@Login, @Password)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@Login", user.login);
                    insertCommand.Parameters.AddWithValue("@Password", user.password);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool CheckUser(string login, string password)
        {
            // Создаем соединение с базой данных MS SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем соединение
                connection.Open();

                // Создаем команду для проверки пароля в базе данных
                using (SqlCommand checkPasswordCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password", connection))
                {
                    // Добавляем параметры для защиты от SQL-инъекций
                    checkPasswordCommand.Parameters.AddWithValue("@Login", login);
                    checkPasswordCommand.Parameters.AddWithValue("@Password", password);

                    // Получаем количество записей, удовлетворяющих условиям запроса
                    int count = Convert.ToInt32(checkPasswordCommand.ExecuteScalar());

                    // Проверяем, совпадает ли пароль
                    if (count == 0)
                    {
                        // Выводим сообщение об ошибке
                        MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false; // Возвращаем false, так как пароль не совпадает
                    }
                }

                // Закрываем соединение с базой данных
                connection.Close();

                // Возвращаем true, так как пароль совпадает
                return true;
            }
        }
        public int GetIdUser(string user, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand getIdCommand = new SqlCommand(
                    "SELECT UserID FROM Users WHERE Login = @Login and Password = @Password;", connection))
                {
                    getIdCommand.Parameters.AddWithValue("@Login", user);
                    getIdCommand.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = getIdCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["UserID"]);
                        }
                    }
                }
                return -1; // Если пользователь не найден
            }
        }

        public bool InsertCar(Car car)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var checkCommand = new SqlCommand("SELECT COUNT(*) FROM Car WHERE Name = @Name AND Year = @Year", connection))
                {
                    checkCommand.Parameters.AddWithValue("@Name", car.name);
                    checkCommand.Parameters.AddWithValue("@Year", car.year);
                    int existingCarsCount = (int)checkCommand.ExecuteScalar();

                    if (existingCarsCount > 0)
                    {
                        return false;
                    }
                }

                using (var insertCommand = new SqlCommand("INSERT INTO Car (Name, Year, TypeCar, MaxSpeed, SeatingCapacity, TypeFuel, FuelOctan, ConsumptionFuel) VALUES (@Name, @Year, @TypeCar, @MaxSpeed, @SeatingCapacity, @TypeFuel, @FuelOctan, @ConsumptionFuel)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", car.name);
                    insertCommand.Parameters.AddWithValue("@Year", car.year);
                    insertCommand.Parameters.AddWithValue("@TypeCar", car.typeCar);
                    insertCommand.Parameters.AddWithValue("@MaxSpeed", car.maxSpeed);
                    insertCommand.Parameters.AddWithValue("@SeatingCapacity", car.seatingCapacity);
                    insertCommand.Parameters.AddWithValue("@TypeFuel", car.fuel);
                    insertCommand.Parameters.AddWithValue("@FuelOctan", car.fuelOctan);
                    insertCommand.Parameters.AddWithValue("@ConsumptionFuel", car.fuelConsumptionGeneral); // Ensure the decimal separator is correct

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteCar(Car car)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand checkRouteCommand = new SqlCommand(
                        "SELECT COUNT(*) FROM Car WHERE Name = @Name;", connection))
                    {
                        checkRouteCommand.Parameters.AddWithValue("@Name", car.name);
                        int count = Convert.ToInt32(checkRouteCommand.ExecuteScalar());
                        if (count == 0)
                        {
                            return false;
                        }
                    }

                    using (SqlCommand deleteCarCommand = new SqlCommand(
                        "DELETE FROM Car WHERE Name = @Name;", connection))
                    {
                        deleteCarCommand.Parameters.AddWithValue("@Name", car.name);
                        deleteCarCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                var result = MessageBox.Show("Ошибка при удалении автмобиля: Автомобиль уже использовался когда-либо. Хотите удалить связанные поездки?", "Ошибка", MessageBoxButton.YesNo, MessageBoxImage.Error);

                if (result == MessageBoxResult.Yes)
                {

                    if (DeleteTripsRelatedToCar(GetIdCar(car)))
                    {
                        DeleteCar(car);
                        return true;
                    }
                }

                return false;
            }

            return true;
        }
        public bool DeleteTripsRelatedToCar(int idCar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteTripsCommandText = "DELETE FROM Trips WHERE IdCar = @IdRoute;";
                    using (SqlCommand deleteTripsCommand = new SqlCommand(deleteTripsCommandText, connection))
                    {
                        deleteTripsCommand.Parameters.AddWithValue("@IdRoute", idCar);
                        deleteTripsCommand.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при удалении поездок, связанных с автомобилем");
            }
            return false;
        }
        public Car GetCarData(string name)
        {
            Car selectCar = new Car();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand selectCarCommand = new SqlCommand("SELECT * FROM Car WHERE Name = @name", connection))
                {
                    selectCarCommand.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader reader = selectCarCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            selectCar = new Car(
                                reader["Name"].ToString(),
                                Convert.ToInt32(reader["Year"]),
                                reader["TypeCar"].ToString(),
                                Convert.ToInt32(reader["MaxSpeed"]),
                                Convert.ToInt32(reader["SeatingCapacity"]),
                                reader["TypeFuel"].ToString(),
                                reader["FuelOctan"].ToString(),
                                Convert.ToDouble(reader["ConsumptionFuel"])
                            );
                        }
                    }
                }
                connection.Close();
            }
            return selectCar;
        }
        public int GetIdCar(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand getIdCommand = new SqlCommand(
                    "SELECT IdCar FROM Car WHERE Name  = @Name  and Year = @Year;", connection))
                {
                    getIdCommand.Parameters.AddWithValue("@Name", car.name);
                    getIdCommand.Parameters.AddWithValue("@Year", car.year);
                    using (SqlDataReader reader = getIdCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["IdCar"]);
                        }
                    }
                }
                return -1;
            }
        }


        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для выбора всех автомобилей из таблицы Car
                using (SqlCommand selectCarsCommand = new SqlCommand("SELECT * FROM Car", connection))
                {
                    using (SqlDataReader reader = selectCarsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car
                            {
                                name = reader["Name"].ToString(),
                                year = Convert.ToInt32(reader["Year"]),
                                typeCar = reader["TypeCar"].ToString(),
                                maxSpeed = Convert.ToInt32(reader["MaxSpeed"]),
                                seatingCapacity = Convert.ToInt32(reader["SeatingCapacity"]),
                                fuel = reader["TypeFuel"].ToString(),
                                fuelOctan = reader["FuelOctan"].ToString(),
                                fuelConsumptionGeneral = Convert.ToDouble(reader["ConsumptionFuel"])
                            };

                            cars.Add(car);
                        }
                    }
                }

                connection.Close();
            }

            return cars;
        }
        public bool InsertRoute(Route route)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверяем, существует ли маршрут уже
                using (var checkRouteCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM Route WHERE ( PointA = @CityOne AND PointB = @CityTwo ) OR ( PointA = @CityTwo AND PointB = @CityOne );", connection))
                {
                    checkRouteCommand.Parameters.AddWithValue("@CityOne", route.cityOne);
                    checkRouteCommand.Parameters.AddWithValue("@CityTwo", route.cityTwo);
                    int count = Convert.ToInt32(checkRouteCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }

                // Если маршрут не существует, добавляем его
                using (var insertRouteCommand = new SqlCommand(
                    "INSERT INTO Route (PointA, PointB, RouteLength) VALUES (@CityOne, @CityTwo, @Distance);", connection))
                {
                    insertRouteCommand.Parameters.AddWithValue("@CityOne", route.cityOne);
                    insertRouteCommand.Parameters.AddWithValue("@CityTwo", route.cityTwo);
                    insertRouteCommand.Parameters.AddWithValue("@Distance", route.distance);
                    int rowsAffected = insertRouteCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateRoute(Route route)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверяем, существует ли маршрут
                using (SqlCommand checkRouteCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM Route WHERE PointA = @CityOne AND PointB = @CityTwo;", connection))
                {
                    checkRouteCommand.Parameters.AddWithValue("@CityOne", route.cityOne);
                    checkRouteCommand.Parameters.AddWithValue("@CityTwo", route.cityTwo);
                    int count = Convert.ToInt32(checkRouteCommand.ExecuteScalar());
                    if (count == 0)
                    {
                        return false; // Маршрут не найден, возвращаем false
                    }
                }

                // Если маршрут существует, обновляем его
                using (SqlCommand updateRouteCommand = new SqlCommand(
                    "UPDATE Route SET RouteLength = @Distance WHERE PointA = @CityOne AND PointB = @CityTwo;", connection))
                {
                    updateRouteCommand.Parameters.AddWithValue("@CityOne", route.cityOne);
                    updateRouteCommand.Parameters.AddWithValue("@CityTwo", route.cityTwo);
                    updateRouteCommand.Parameters.AddWithValue("@Distance", route.distance);
                    updateRouteCommand.ExecuteNonQuery();
                }

                return true; // Обновление маршрута прошло успешно
            }
        }
        public bool DeleteRoute(Route route)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand checkRouteCommand = new SqlCommand(
                        "SELECT COUNT(*) FROM Route WHERE PointA = @PointA AND PointB = @PointB;", connection))
                    {
                        checkRouteCommand.Parameters.AddWithValue("@PointA", route.cityOne);
                        checkRouteCommand.Parameters.AddWithValue("@PointB", route.cityTwo);
                        int count = Convert.ToInt32(checkRouteCommand.ExecuteScalar());
                        if (count == 0)
                        {
                            return false;
                        }
                    }

                    using (SqlCommand deleteRouteCommand = new SqlCommand(
                        "DELETE FROM Route WHERE PointA = @CityOne AND PointB = @CityTwo;", connection))
                    {
                        deleteRouteCommand.Parameters.AddWithValue("@CityOne", route.cityOne);
                        deleteRouteCommand.Parameters.AddWithValue("@CityTwo", route.cityTwo);
                        deleteRouteCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                var result = MessageBox.Show("Ошибка при удалении маршрута: Маршрут уже использовался когда-либо. Хотите удалить связанные поездки?", "Ошибка", MessageBoxButton.YesNo, MessageBoxImage.Error);

                if (result == MessageBoxResult.Yes)
                {
                    if (DeleteTripsRelatedToRoute(GetIdRoute(route)))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand deleteRouteCommand = new SqlCommand(
                                "DELETE FROM Route WHERE PointA = @CityOne AND PointB = @CityTwo;", connection))
                            {
                                deleteRouteCommand.Parameters.AddWithValue("@CityOne", route.cityOne);
                                deleteRouteCommand.Parameters.AddWithValue("@CityTwo", route.cityTwo);
                                deleteRouteCommand.ExecuteNonQuery();
                            }
                        }
                        return true;
                    }
                }

                return false;
            }
        }

        public int GetIdRoute(Route route)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand getIdCommand = new SqlCommand(
                    "SELECT RouteID FROM Route WHERE PointA  = @PointA  and PointB  = @PointB ;", connection))
                {
                    getIdCommand.Parameters.AddWithValue("@PointA", route.cityOne);
                    getIdCommand.Parameters.AddWithValue("@PointB ", route.cityTwo);
                    using (SqlDataReader reader = getIdCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["RouteID"]);
                        }
                    }
                }
                return -1;
            }
        }

        public List<Route> GetAllRoutes()
        {
            List<Route> routesWithIds = new List<Route>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для выбора всех маршрутов из таблицы Route
                using (SqlCommand selectRoutesCommand = new SqlCommand("SELECT * FROM Route", connection))
                {
                    using (SqlDataReader reader = selectRoutesCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Route route = new Route
                            {
                                cityOne = reader["PointA"].ToString(),
                                cityTwo = reader["PointB"].ToString(),
                                distance = Convert.ToDouble(reader["RouteLength"])
                            };

                            routesWithIds.Add(route);
                        }
                    }
                }

                connection.Close();
            }

            return routesWithIds;
        }

        public List<Fuel> GetFuelList(string fuelType)
        {
            List<Fuel> fuels = new List<Fuel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Fuel WHERE FuelType = @FuelType";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FuelType", fuelType);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Fuel fuel = new Fuel
                    (
                        Convert.ToInt32(reader["FuelId"]),
                        Convert.ToString(reader["FuelType"]),
                        Convert.ToString(reader["OctaneNumber"]),
                        Convert.ToDouble(reader["FuelPrice"])
                    );
                    fuels.Add(fuel);
                }

                reader.Close();
            }

            return fuels;
        }
        public bool InsertFuel(Fuel fuel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка наличия пользователя с таким логином
                using (var checkCommand = new SqlCommand("SELECT COUNT(*) FROM Fuel WHERE FuelType = @FuelType AND OctaneNumber = @OctaneNumber", connection))
                {
                    checkCommand.Parameters.AddWithValue("@FuelType", fuel.FuelType);
                    checkCommand.Parameters.AddWithValue("@OctaneNumber", fuel.OctaneNumber);
                    int existingUsersCount = (int)checkCommand.ExecuteScalar();
                    if (existingUsersCount > 0)
                    {
                        return false;
                    }
                }


                using (var insertCommand = new SqlCommand("INSERT INTO Fuel (FuelType, OctaneNumber, FuelPrice) VALUES (@FuelType, @OctaneNumber,@FuelPrice)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@FuelType", fuel.FuelType);
                    insertCommand.Parameters.AddWithValue("@OctaneNumber", fuel.OctaneNumber);
                    insertCommand.Parameters.AddWithValue("@FuelPrice", fuel.FuelPrice);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateFuelPrice(Fuel fuel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var checkCommand = new SqlCommand("SELECT COUNT(*) FROM Fuel WHERE FuelType = @FuelType AND OctaneNumber = @OctaneNumber", connection))
                {
                    checkCommand.Parameters.AddWithValue("@FuelType", fuel.FuelType);
                    checkCommand.Parameters.AddWithValue("@OctaneNumber", fuel.OctaneNumber);
                    int existingFuelCount = (int)checkCommand.ExecuteScalar();
                    if (existingFuelCount == 0)
                    {
                        // Запись о топливе не найдена, генерируем исключение
                        MessageBox.Show("Топливо не найдено для обновления цены.");
                        return false; // Прерываем выполнение метода, так как топливо не найдено
                    }
                }

                // Обновление цены на топливо
                using (var updateCommand = new SqlCommand("UPDATE Fuel SET FuelPrice = @FuelPrice WHERE FuelType = @FuelType AND OctaneNumber = @OctaneNumber", connection))
                {
                    updateCommand.Parameters.AddWithValue("@FuelType", fuel.FuelType);
                    updateCommand.Parameters.AddWithValue("@OctaneNumber", fuel.OctaneNumber);
                    updateCommand.Parameters.AddWithValue("@FuelPrice", fuel.FuelPrice);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteFuel(string fuelType, string octaneNumber)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка использования октанового числа в таблице Car
                using (var checkUsageCommand = new SqlCommand("SELECT COUNT(*) FROM Car WHERE FuelOctan = @OctaneNumber", connection))
                {
                    checkUsageCommand.Parameters.AddWithValue("@OctaneNumber", octaneNumber);
                    int carCountUsingFuel = (int)checkUsageCommand.ExecuteScalar();
                    if (carCountUsingFuel > 0)
                    {
                        // Топливо используется в таблице Car, выводим сообщение
                        MessageBox.Show("Невозможно удалить топливо, так как оно используется в таблице Car.");
                        return false; // Прерываем выполнение метода, так как топливо используется
                    }
                }

                // Удаление записи о топливе
                using (var deleteCommand = new SqlCommand("DELETE FROM Fuel WHERE FuelType = @FuelType AND OctaneNumber = @OctaneNumber", connection))
                {
                    deleteCommand.Parameters.AddWithValue("@FuelType", fuelType);
                    deleteCommand.Parameters.AddWithValue("@OctaneNumber", octaneNumber);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public bool DeleteTripsRelatedToRoute(int idRoute)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteTripsCommandText = "DELETE FROM Trips WHERE IdRoute = @IdRoute;";
                    using (SqlCommand deleteTripsCommand = new SqlCommand(deleteTripsCommandText, connection))
                    {
                        deleteTripsCommand.Parameters.AddWithValue("@IdRoute", idRoute);
                        deleteTripsCommand.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при удалении поездок, связанных с маршрутом");
            }
            return false;
        }
        public List<Trips> GetAllTrips()
        {
            List<Trips> trips = new List<Trips>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Trips", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Trips trip = new Trips
                        {
                            idUser = reader.GetInt32(0),
                            idCar = reader.GetInt32(1),
                            idRoute = reader.GetInt32(2),
                            distance = reader.GetDouble(3),
                            consumption = reader.GetDouble(4),
                            averageConsumption = reader.GetDouble(5),
                            date = reader.GetString(6),
                            price = reader.GetDouble(7),
                            timeStart = reader.GetDateTime(8),
                            timeFinish = reader.GetDateTime(9)
                        };
                        trips.Add(trip);
                    }
                }
            }

            return trips;
        }
        public List<TripInfo> GetTripsByUserId(int userId)
        {
            List<TripInfo> trips = new List<TripInfo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"SELECT
                                    u.Login, 
                                    c.Name, 
                                    r.PointA,
                                    r.PointB,
                                    t.Distance,
                                    t.Consumption,
                                    t.AverageConsumption,
                                    t.TripDate,
                                    t.Price,
                                    t.TimeStart,
                                    t.TimeFinish
                                FROM
                                    Trips t
                                JOIN
                                    Users u ON t.IdUser = u.UserID
                                JOIN
                                    Car c ON t.IdCar = c.IdCar
                                JOIN
                                    Route r ON t.IdRoute = r.RouteID
                                WHERE
                                    t.IdUser = @UserId";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TripInfo trip = new TripInfo(
                        reader["Login"].ToString(),
                        reader["Name"].ToString(),
                        reader["PointA"].ToString(),
                        reader["PointB"].ToString(),
                        Convert.ToDouble(reader["Distance"]),
                        Convert.ToDouble(reader["Consumption"]),
                        Convert.ToDouble(reader["AverageConsumption"]),
                        Convert.ToDateTime(reader["TripDate"]),
                        Convert.ToDecimal(reader["Price"]),
                        Convert.ToDateTime(reader["TimeStart"]),
                       Convert.ToDateTime(reader["TimeFinish"])
                    );

                    trips.Add(trip);
                }

                reader.Close();
            }
            return trips;
        }


        public List<TripInfo> GetTripsBetweenDate(int userId, DateTime? startDate, DateTime? endDate)
        {
            List<TripInfo> trips = new List<TripInfo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"SELECT
                            t.IdTrip,
                            u.Login, 
                            c.Name AS CarName, 
                            r.PointA AS RoutePointA,
                            r.PointB AS RoutePointB,
                            t.Distance,
                            t.Consumption,
                            t.AverageConsumption,
                            t.TripDate,
                            t.Price,
                            t.TimeStart,
                            t.TimeFinish
                        FROM
                            Trips t
                        JOIN
                            Users u ON t.IdUser = u.UserID
                        JOIN
                            Car c ON t.IdCar = c.IdCar
                        JOIN
                            Route r ON t.IdRoute = r.RouteID
                        WHERE
                            t.IdUser = @UserId";

                // Создаем команду SQL с предварительно добавленными параметрами
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                if (endDate.HasValue)
                {
                    sqlQuery += " AND t.TripDate <= @EndDate";
                    command.Parameters.AddWithValue("@EndDate", endDate.Value);
                }
                if (startDate.HasValue)
                {
                    sqlQuery += " AND t.TripDate >= @StartDate";
                    command.Parameters.AddWithValue("@StartDate", startDate.Value);
                }

                // Используем команду для выполнения запроса SQL
                command.CommandText = sqlQuery; // Устанавливаем текст запроса
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TripInfo trip = new TripInfo(
                        reader["Login"].ToString(),
                        reader["CarName"].ToString(),
                        reader["RoutePointA"].ToString(),
                        reader["RoutePointB"].ToString(),
                        Convert.ToDouble(reader["Distance"]),
                        Convert.ToDouble(reader["Consumption"]),
                        Convert.ToDouble(reader["AverageConsumption"]),
                        Convert.ToDateTime(reader["TripDate"]),
                        Convert.ToDecimal(reader["Price"]),
                        Convert.ToDateTime(reader["TimeStart"]),
                        Convert.ToDateTime(reader["TimeFinish"])
                    );
                    trips.Add(trip);
                }

                reader.Close();
            }
            return trips;
        }
        public bool InsertTrip(Trips trip)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var insertCommand = new SqlCommand("INSERT INTO Trips (IdUser, IdCar, IdRoute, Distance, Consumption, AverageConsumption, TripDate, Price, TimeStart, TimeFinish) VALUES (@IdUser, @IdCar, @IdRoute, @Distance, @Consumption, @AverageConsumption, @TripDate, @Price, @TimeStart, @TimeFinish)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@IdUser", trip.idUser);
                    insertCommand.Parameters.AddWithValue("@IdCar", trip.idCar);
                    insertCommand.Parameters.AddWithValue("@IdRoute", trip.idRoute);
                    insertCommand.Parameters.AddWithValue("@Distance", trip.distance);
                    insertCommand.Parameters.AddWithValue("@Consumption", trip.consumption);
                    insertCommand.Parameters.AddWithValue("@AverageConsumption", trip.averageConsumption);
                    insertCommand.Parameters.AddWithValue("@TripDate", DateTime.Parse(trip.date));
                    insertCommand.Parameters.AddWithValue("@Price", trip.price);
                    insertCommand.Parameters.AddWithValue("@TimeStart", trip.timeStart);
                    insertCommand.Parameters.AddWithValue("@TimeFinish", trip.timeFinish);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public int GetIdRoute(string pointA, string pointB)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand getIdCommand = new SqlCommand(
                    "SELECT RouteID FROM Route WHERE PointA = @PointA and PointB = @PointB;", connection))
                {
                    getIdCommand.Parameters.AddWithValue("@PointA", pointA);
                    getIdCommand.Parameters.AddWithValue("@PointB", pointB);

                    using (SqlDataReader reader = getIdCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["RouteID"]);
                        }
                    }
                }
                return -1;
            }
        }
        public bool InsertFavoriteRoute(int IdUser, int IdRoute)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (var checkRouteCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM FavoriteRoute WHERE IdUser = @IdUser AND IdRoute = @IdRoute;", connection))
                {
                    checkRouteCommand.Parameters.AddWithValue("@IdUser", IdUser);
                    checkRouteCommand.Parameters.AddWithValue("@IdRoute", IdRoute);
                    int count = Convert.ToInt32(checkRouteCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }


                using (var insertRouteCommand = new SqlCommand(
                    "INSERT INTO FavoriteRoute (IdUser, IdRoute) VALUES (@IdUser, @IdRoute);", connection))
                {
                    insertRouteCommand.Parameters.AddWithValue("@IdUser", IdUser);
                    insertRouteCommand.Parameters.AddWithValue("@IdRoute", IdRoute);
                    int rowsAffected = insertRouteCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteFavoriteRoute(int IdUser, int IdRoute)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (var checkRouteCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM FavoriteRoute WHERE IdUser = @IdUser AND IdRoute = @IdRoute;", connection))
                {
                    checkRouteCommand.Parameters.AddWithValue("@IdUser", IdUser);
                    checkRouteCommand.Parameters.AddWithValue("@IdRoute", IdRoute);
                    int count = Convert.ToInt32(checkRouteCommand.ExecuteScalar());
                    if (count == 0)
                    {
                        return false;
                    }
                }
                using (var deleteRouteCommand = new SqlCommand(
                    "DELETE FROM FavoriteRoute WHERE IdUser = @IdUser AND IdRoute = @IdRoute;", connection))
                {
                    deleteRouteCommand.Parameters.AddWithValue("@IdUser", IdUser);
                    deleteRouteCommand.Parameters.AddWithValue("@IdRoute", IdRoute);
                    deleteRouteCommand.ExecuteNonQuery();
                }
            }

            return true;
        }
        public List<FavoriteRoute> GetFavoriteRoutes(int idUser)
        {
            List<FavoriteRoute> favoriteRoutes = new List<FavoriteRoute>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL-запрос для выбора всех маршрутов из таблицы FavoriteRoute для указанного IdUser
                string sqlQuery = @"
                    SELECT FR.IdFavoriteRoute, FR.IdUser, FR.IdRoute, R.PointA, R.PointB
                    FROM FavoriteRoute FR
                    JOIN Route R ON FR.IdRoute = R.RouteID
                    WHERE FR.IdUser = @IdUser";

                using (SqlCommand selectFavoriteRoutesCommand = new SqlCommand(sqlQuery, connection))
                {
                    selectFavoriteRoutesCommand.Parameters.AddWithValue("@IdUser", idUser);

                    using (SqlDataReader reader = selectFavoriteRoutesCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FavoriteRoute route = new FavoriteRoute(
                                reader["PointA"].ToString(),
                                reader["PointB"].ToString()
                            );

                            favoriteRoutes.Add(route);
                        }
                    }
                }

                connection.Close();
            }

            return favoriteRoutes;
        }
    }
}
