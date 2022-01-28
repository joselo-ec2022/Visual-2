using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
   public class Nomina
    {
        public int NominaId { get; set; }
        public Empleado Empleado { get; set; }

        public Cargo Cargo { get; set; }

        public Sueldo Sueldo { get; set; }






    }
}
