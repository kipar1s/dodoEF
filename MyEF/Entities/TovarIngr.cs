using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class TovarIngr
    {
        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }

        public int IngrId { get; set; }
        public Ingr Ingr { get; set; }

        public int Quantity { get; set; }  // сколько единиц ингредиента идёт на товар
    }
}
