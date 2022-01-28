using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Sueldo_final
    {

        public int Sueldo_FinalId { get; set; }
        public double sueldo_base { get; set; }
        public double sueldo_descontado { get; set; }
        public String tipo_decimo { get; set; }
        public double sueldo_recibido { get; set; }
        public double sueldo_anual_final { get; set; }
        public double total_decimo_recibido { get; set; }

        // referencia con empleado
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        // referencia con aportes
        public List<Aportes> Aportes { get; set; }


    }
}
