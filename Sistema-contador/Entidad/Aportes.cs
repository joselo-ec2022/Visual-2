using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Aportes
    {
        public int AportesId { get; set; }
        public double aporte_patronal_dado { get; set; }
        public double aporte_personal_dado { get; set; }
        public String total_decimo_dado { get; set; }
        public int tiempo_aportado { get; set; }

        public Nomina Nomina { get; set; }
        public int NominaId { get; set; }

        public List<Nomina> NominaList { get; set; }
    }
}
