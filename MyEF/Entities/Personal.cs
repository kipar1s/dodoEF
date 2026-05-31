using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class Personal
    {
        public int Id { get; set; }
        public string FullName {  get; set; }

        public int Stage {  get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int categoriId { get; set; }
        public Categori categori { get; set; }
        public List<Oder> oders { get; set; } = new ();

        // Связь многие-ко-многим с уровнями квалификации (если требуется)
        public List<PersonalEvelobilitile> PersonalEvelobilitiles { get; set; } = new();

    }
}
