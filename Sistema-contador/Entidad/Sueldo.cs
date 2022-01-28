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


        // referencia con empleado
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }


        // referencia a nomina
        //public int NominaId { get; set; }

        //public Nomina Nomina { get; set; }

        public List<Nomina> Nominas { get; set; }
    }
}
