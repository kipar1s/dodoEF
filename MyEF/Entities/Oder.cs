using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Oder
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int Summa { get; set; }
        public string Status { get; set; }
        public string Adress_d { get; set; }
    }
}
