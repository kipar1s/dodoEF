using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Plateg
    {
        public int Id { get; set; }
        public Oder oder { get; set; }
        public int oderid { get; set; }
        public string Status_PL { get; set; }
        public string Sposob_PL { get; set; }
    }
}
