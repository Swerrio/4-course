namespace CarRental
{
    // Основной объект приложения — автомобиль.
    // С ЛР №8 объект хранится в базе данных, поэтому у него появился
    // первичный ключ Id.
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
    }
}
