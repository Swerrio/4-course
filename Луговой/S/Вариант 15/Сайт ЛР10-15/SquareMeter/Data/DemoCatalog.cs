using System;
using System.Collections.Generic;
using System.Linq;
using SquareMeter.Models;

namespace SquareMeter.Data
{
    // Демонстрационные данные каталога. В ЛР №10 база данных не
    // используется, поэтому объекты хранятся в памяти. В следующих
    // работах этот класс заменит обращение к базе.
    public static class DemoCatalog
    {
        private static readonly List<Category> categories = new List<Category>
        {
            new Category { Key = "flats", Title = "Квартиры", Icon = "bi-building",
                Image = "cat-flats.jpg", Description = "Вторичное жильё в обжитых районах" },
            new Category { Key = "new", Title = "Новостройки", Icon = "bi-buildings",
                Image = "cat-new.jpg", Description = "Квартиры в сданных и строящихся ЖК" },
            new Category { Key = "houses", Title = "Дома и коттеджи", Icon = "bi-house-door",
                Image = "cat-houses.jpg", Description = "Загородная жизнь рядом с городом" },
            new Category { Key = "commercial", Title = "Коммерческая", Icon = "bi-briefcase",
                Image = "cat-commercial.jpg", Description = "Офисы, торговые помещения, склады" }
        };

        private static readonly List<Property> items = new List<Property>
        {
            new Property { Id = 1, Title = "2-комнатная квартира в ЖК «Сидней Сити»", CategoryKey = "new",
                City = "Москва", District = "Хорошёво-Мнёвники", Price = 21900000m, Area = 58.4, Rooms = 2,
                Floor = "17 из 42", Image = "obj-1.jpg", Badge = "Новостройка", IsFeatured = true,
                Description = "Видовая квартира с панорамными окнами на реку. Отделка white box, " +
                    "закрытый двор без машин, подземный паркинг и детский сад в комплексе." },
            new Property { Id = 2, Title = "Коттедж с участком 12 соток", CategoryKey = "houses",
                City = "Истра", District = "КП «Лесные дали»", Price = 34500000m, Area = 186, Rooms = 5,
                Floor = "2 этажа", Image = "obj-2.jpg", Badge = "Хит недели", IsFeatured = true,
                Description = "Кирпичный дом в охраняемом посёлке: газ, центральный водопровод, " +
                    "гараж на две машины, ухоженный участок с газоном и террасой." },
            new Property { Id = 3, Title = "3-комнатная квартира в историческом доме", CategoryKey = "flats",
                City = "Санкт-Петербург", District = "Центральный", Price = 27800000m, Area = 96.7, Rooms = 3,
                Floor = "3 из 6", Image = "obj-3.jpg", Badge = "Центр", IsFeatured = true,
                Description = "Квартира с высокими потолками в доходном доме начала XX века. " +
                    "Сохранена лепнина, сделан капитальный ремонт инженерных сетей." },
            new Property { Id = 4, Title = "1-комнатная квартира рядом с парком", CategoryKey = "flats",
                City = "Казань", District = "Ново-Савиновский", Price = 8900000m, Area = 41.2, Rooms = 1,
                Floor = "5 из 9", Image = "obj-4.jpg", Badge = "Готова к въезду", IsFeatured = true,
                Description = "Светлая квартира с ремонтом и мебелью. В пешей доступности парк, " +
                    "школа, поликлиника и остановка метро." },
            new Property { Id = 5, Title = "Таунхаус в малоэтажном квартале", CategoryKey = "houses",
                City = "Екатеринбург", District = "Академический", Price = 16400000m, Area = 128, Rooms = 4,
                Floor = "3 уровня", Image = "obj-5.jpg", Badge = "Скидка 5%",
                Description = "Таунхаус с отдельным входом, небольшим садом и местом для машины. " +
                    "Рядом гимназия и торговый центр." },
            new Property { Id = 6, Title = "Офис 240 м² в бизнес-центре класса A", CategoryKey = "commercial",
                City = "Москва", District = "Пресненский", Price = 76000000m, Area = 240, Rooms = 0,
                Floor = "11 из 24", Image = "obj-6.jpg", Badge = "Для бизнеса",
                Description = "Открытая планировка, собственный санузел и кухня, круглосуточная " +
                    "охрана и подземный паркинг для арендаторов." }
        };

        public static IList<Category> Categories()
        {
            foreach (Category c in categories)
            {
                c.Count = items.Count(p => p.CategoryKey == c.Key);
            }
            return categories;
        }

        public static Category FindCategory(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) return null;
            return categories.FirstOrDefault(c =>
                string.Equals(c.Key, key.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static IList<Property> All()
        {
            return items;
        }

        public static IList<Property> ByCategory(string key)
        {
            Category c = FindCategory(key);
            return c == null ? items : items.Where(p => p.CategoryKey == c.Key).ToList();
        }

        public static IList<Property> Featured()
        {
            return items.Where(p => p.IsFeatured).ToList();
        }

        public static Property Find(int id)
        {
            return items.FirstOrDefault(p => p.Id == id);
        }

        public static IList<Advantage> Advantages()
        {
            return new List<Advantage>
            {
                new Advantage { Icon = "bi-patch-check", Title = "Проверенные объекты",
                    Text = "Юрист проверяет документы и историю каждой квартиры до публикации." },
                new Advantage { Icon = "bi-graph-up-arrow", Title = "Честная цена",
                    Text = "Показываем цену за квадратный метр и сравнение с соседними предложениями." },
                new Advantage { Icon = "bi-headset", Title = "Персональный менеджер",
                    Text = "Один специалист ведёт сделку от первого просмотра до ключей." },
                new Advantage { Icon = "bi-shield-lock", Title = "Безопасная сделка",
                    Text = "Расчёты через аккредитив банка и электронная регистрация права." }
            };
        }
    }
}
