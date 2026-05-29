using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Telefon { get; set; }
        public string Adress_C { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Oder> oders { get; set; }
    }
}
