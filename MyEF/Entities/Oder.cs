using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace dodoEF.MyEF.Entities
{
    public class Oder
    {
        public int Id { get; set; }

        // Внешний ключ к клиенту
        public int clientId { get; set; }
        public Client client { get; set; }

        public DateTime date { get; set; }
        public int Summa { get; set; }
        public string Status { get; set; }
        public string Adress_d { get; set; }

        // Внешний ключ к платежу (один-к-одному)
        public int plategid { get; set; }
        public Plateg plategs { get; set; }

        // Внешний ключ к сотруднику
        public int? personalId { get; set; } = 0;
        public Personal personal { get; set; }

        // Связь многие-ко-многим с товарами через промежуточную таблицу OrderTovar
        public List<OderTovar> OderTovars { get; set; } = new();

        // Не привязанные к БД свойства (для удобства)
        [NotMapped]
        public string ClietNik
        {
            get => client?.FullName ?? "";
            set { if (client != null) client.FullName = value; }
        }
        [NotMapped]
        public string ClietAdress
        {
            get => client?.Adress_C ?? "";
            set { if (client != null) client.Adress_C = value; }
        }

        [NotMapped]
        public int ClietTelefon
        {
            get => client?.Telefon ?? 9009090;
            set { if (client != null) client.Telefon = value; }
        }

        [NotMapped]
        public string Plateg_SP
        {
            get => plategs?.Sposob_PL ?? "Наличными";
            set { if (plategs != null) plategs.Sposob_PL = value; }
        }

        [NotMapped]
        public string Plateg_ST
        {
            get => plategs?.Status_PL ?? "Отменено";
            set { if (plategs != null) plategs.Status_PL = value; }
        }
    }
}