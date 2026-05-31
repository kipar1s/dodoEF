using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class OderTovar
    {
        public int OderId { get; set; }
        public Oder Oder { get; set; }

        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }

        public int Quantity { get; set; }  // количество единиц товара в заказе
       
        
    }
}
