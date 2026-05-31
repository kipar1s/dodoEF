using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Plateg
    {
        public int Id { get; set; }        
        public string Status_PL { get; set; }
        public string Sposob_PL { get; set; }
        // Обратная ссылка на заказ (один-к-одному)
        public Oder Oder { get; set; }
    }
}
