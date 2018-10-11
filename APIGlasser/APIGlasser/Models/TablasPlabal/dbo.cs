using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGlasser.Models.TablasPlabal
{
    public partial class ECOM_PEDIDOS
    {
        public int ID { get; set; }
    }

    public partial class Feriados
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
    }
}
