using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Aportes
    {
        public int AportesId { get; set; }
        public float  aporte_patronal { get; set; }
        public float aporte_personal_dado { get; set; }
        public String total_decimo_dado { get; set; }
        public int tiempo_aportado { get; set; }
   
    }
}
