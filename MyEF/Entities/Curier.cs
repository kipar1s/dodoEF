using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoEF.MyEF.Entities
{
    public class Curier : Personal
    {
        public int Num_VY { get; set; }   
        public int Num_Car { get; set; }
    }
}
