using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class PersonalEvelobilitile
    {
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }

        public int EvelobilitileId { get; set; }
        public Evelobilitile Evelobilitile { get; set; }
    }
}
