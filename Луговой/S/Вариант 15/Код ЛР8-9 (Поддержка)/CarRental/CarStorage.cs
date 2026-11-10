using System.Collections.Generic;

namespace CarRental
{
    // С ЛР №8 автомобили хранятся в базе данных, поэтому список
    // в памяти больше не нужен. Здесь остался только журнал
    // оформленных аренд текущего сеанса работы.
    public static class CarStorage
    {
        public static List<string> Rents = new List<string>();
    }
}
