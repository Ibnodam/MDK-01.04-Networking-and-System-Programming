namespace Rest_Api.Models
{
    public class OrdersRegistration
    {
        public int Id { get; set; } // № п/п
        public required string Customer { get; set; } // Фирма-заказчик
        public required string ProductCode { get; set; } // Код изделия
        public string? ProductName { get; set; } // Наименование
        public decimal Weight { get; set; } // Вес изделия
        public DateTime OrderDate { get; set; } // Дата исполнения заказа
        public decimal OrderCost { get; set; } // Стоимость заказа
    }
}
