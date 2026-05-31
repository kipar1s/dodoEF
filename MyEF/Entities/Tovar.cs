using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Tovar
    {
        public int Id { get; set; }
        public string FullName { get; set; }        
        public int Price { get; set; }
        public string Catifori_T { get; set; }
        public int Callory { get; set; }
        // Связь многие-ко-многим с заказами через OrderTovar
        public List<OderTovar> OrderTovars { get; set; } = new();

        // Связь многие-ко-многим с ингредиентами через TovarIngr
        public List<TovarIngr> TovarIngrs { get; set; } = new();

    }
}
