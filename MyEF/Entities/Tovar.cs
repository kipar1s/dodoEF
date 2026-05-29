using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Tovar
    {
        public int Id { get; set; }
        public Ingr ingr { get; set; }
        public int ingrId { get; set; }
        public string FullName { get; set; }        
        public int Price { get; set; }
        public string Catifori_T { get; set; }
        public int Callory { get; set; }
        public List<Oder> oders { get; set; }
        //public List<Ingr> ingrs { get; set; }
    }
}
