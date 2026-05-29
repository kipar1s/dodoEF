using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Evelobilitile
    {
        public int Id { get; set; }
        public int Pizziria { get; set; }
        public Personal Personal { get; set; }
        public int personalId { get; set; }
        public string FullName_P { get; set; }
        public int Reit_K_D { get; set; }
        public string Enum_Oder { get; set; }
        public string Enum_Evel { get; set; }
        public string Procent { get; set; }
    }
}
