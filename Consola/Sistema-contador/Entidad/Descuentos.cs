using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Descuentos
    {
        public int NominaId { get; set; }
        public Nomina Nomina { get; set; }
        

        public int AportesId { get; set; }
        public Aportes Aportes { get; set; }

    }
}
