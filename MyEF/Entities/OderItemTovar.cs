using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class OderItemTovar
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Oder Order { get; set; }  // навигация к заказу

        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }  // навигация к товару

        public int Quantity { get; set; } = 1;  // количество

        // Можно добавить цену на момент заказа
        public decimal PriceAtOrder { get; set; }
    }
}
