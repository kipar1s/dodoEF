using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Oder
    {
        public int Id { get; set; }
        public Client client { get; set; }
        public int clientId { get; set; }
        [NotMapped]
        public string ClietNik 
        {
            get {
                if(client != null) return client.FullName;
                return "";
            }
            set { 
                client?.FullName = value;
            }
        }
        [NotMapped]
        public int ClietTelefon
        {
            get {
                if(client != null) return client.Telefon;
                return 9009090;
            }
            set { 
                client?.Telefon = value;
            }
        }

        public DateTime date { get; set; }
        public int Summa { get; set; }
        public string Status { get; set; }
        public string Adress_d { get; set; }
        public List<Plateg> plategs { get; set; }
         public List<Tovar> tovars { get; set; }

    }
}
