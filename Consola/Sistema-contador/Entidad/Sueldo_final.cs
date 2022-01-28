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


        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public int AportesId { get; set; }
        public Aportes Aportes { get; set; }

    }
}
