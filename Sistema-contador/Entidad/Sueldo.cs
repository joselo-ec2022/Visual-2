using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Sueldo
    {

        public int SueldoId { get; set; }
        public double  sueldo_estipulado { get; set; }
        public Boolean estado_sueldo { get; set; }
        public DateTime fecha_pago { get; set; }

        public Empleado Empleado { get; set; }
        public int empleadoId { get; set; }

    }
}
