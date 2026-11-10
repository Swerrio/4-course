using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CarRental
{
    // Работа с таблицей cars. Все операции выполняются в базе данных,
    // список в памяти больше не является источником данных.
    public static class CarRepository
    {
        // Загрузка автомобилей; фильтр по типу выполняется запросом
        public static DataTable Load(string type)
        {
            using (DbConnection conn = Db.Open())
            {
                bool all = string.IsNullOrEmpty(type) || type == "Все типы";
                string sql = "SELECT id, brand, model, car_type, price " +
                    "FROM cars";
                if (!all)
                {
                    sql += " WHERE car_type = @type";
                }
                sql += " ORDER BY id";

                using (DbCommand cmd = Db.Command(conn, sql))
                {
                    if (!all)
                    {
                        Db.Param(cmd, "@type", type);
                    }
                    DataTable table = new DataTable();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                    return table;
                }
            }
        }

        // Поиск по марке — используется на главном окне
        public static DataTable Search(string brand)
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT id, brand, model, car_type, price FROM cars " +
                    "WHERE brand = @brand ORDER BY id"))
                {
                    Db.Param(cmd, "@brand", brand);
                    DataTable table = new DataTable();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                    return table;
                }
            }
        }

        public static Car GetById(int id)
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT id, brand, model, car_type, price FROM cars " +
                    "WHERE id = @id"))
                {
                    Db.Param(cmd, "@id", id);
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }
                        return Read(reader);
                    }
                }
            }
        }

        public static List<Car> All()
        {
            List<Car> cars = new List<Car>();
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT id, brand, model, car_type, price FROM cars " +
                    "ORDER BY id"))
                {
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Add(Read(reader));
                        }
                    }
                }
            }
            return cars;
        }

        // ------------------------------------------------- изменение
        public static void Add(Car car)
        {
            Session.RequireAdmin("добавление автомобиля");
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "INSERT INTO cars (brand, model, car_type, price) " +
                    "VALUES (@brand, @model, @type, @price)"))
                {
                    Db.Param(cmd, "@brand", car.Brand);
                    Db.Param(cmd, "@model", car.Model);
                    Db.Param(cmd, "@type", car.Type);
                    Db.Param(cmd, "@price", car.Price);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Car car)
        {
            Session.RequireAdmin("изменение автомобиля");
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "UPDATE cars SET brand = @brand, model = @model, " +
                    "car_type = @type, price = @price WHERE id = @id"))
                {
                    Db.Param(cmd, "@brand", car.Brand);
                    Db.Param(cmd, "@model", car.Model);
                    Db.Param(cmd, "@type", car.Type);
                    Db.Param(cmd, "@price", car.Price);
                    Db.Param(cmd, "@id", car.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Удаление выполняется по первичному ключу, а не по номеру строки
        public static void Delete(int id)
        {
            Session.RequireAdmin("удаление автомобиля");
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "DELETE FROM cars WHERE id = @id"))
                {
                    Db.Param(cmd, "@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Count()
        {
            using (DbConnection conn = Db.Open())
            {
                using (DbCommand cmd = Db.Command(conn,
                    "SELECT COUNT(*) FROM cars"))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Начальное заполнение каталога, если таблица пуста
        public static void SeedDemoData()
        {
            if (Count() > 0)
            {
                return;
            }
            string[,] demo = {
                { "Toyota", "Camry", "Бизнес", "3500" },
                { "Kia", "Rio", "Эконом", "1800" },
                { "Skoda", "Octavia", "Комфорт", "2400" },
                { "Toyota", "Land Cruiser", "Внедорожник", "6200" },
                { "Lada", "Granta", "Эконом", "1200" }
            };

            using (DbConnection conn = Db.Open())
            {
                for (int i = 0; i < demo.GetLength(0); i++)
                {
                    using (DbCommand cmd = Db.Command(conn,
                        "INSERT INTO cars (brand, model, car_type, price) " +
                        "VALUES (@brand, @model, @type, @price)"))
                    {
                        Db.Param(cmd, "@brand", demo[i, 0]);
                        Db.Param(cmd, "@model", demo[i, 1]);
                        Db.Param(cmd, "@type", demo[i, 2]);
                        Db.Param(cmd, "@price",
                            decimal.Parse(demo[i, 3]));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static Car Read(DbDataReader reader)
        {
            Car car = new Car();
            car.Id = Convert.ToInt32(reader["id"]);
            car.Brand = Convert.ToString(reader["brand"]);
            car.Model = reader["model"] == DBNull.Value
                ? "" : Convert.ToString(reader["model"]);
            car.Type = reader["car_type"] == DBNull.Value
                ? "" : Convert.ToString(reader["car_type"]);
            car.Price = Convert.ToDecimal(reader["price"]);
            return car;
        }
    }
}
