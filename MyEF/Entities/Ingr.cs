using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Ingr
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Cost { get; set; }
        public DateTime date { get; set; }
        public int Quantity { get; set; }  // остаток на складе

        // Связь многие-ко-многим с товарами через TovarIngr
        public List<TovarIngr> TovarIngrs { get; set; } = new();

        // Не привязанные к БД свойства (оставлены как пример, но лучше их убрать, если не нужны)
        [NotMapped]
        public string TovarName
        {
            get => TovarIngrs.Count > 0 ? TovarIngrs[0].Tovar?.FullName : "Пепперони фреш";
            set {  }
        }

        [NotMapped]
        public int TovarPrice
        {
            get => TovarIngrs.Count > 0 ? TovarIngrs[0].Tovar?.Price ?? 259 : 259;
            set {  }
        }
    }
}

