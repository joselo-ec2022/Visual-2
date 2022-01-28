using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public String nombre_cargo { get; set; }
        public String tipo_departamento { get; set; }
        public String tipo_funcion { get; set; }

        //relacion con empleado

        public List<Empleado> Empleado { get; set; }


        // relacion con nomina

        public Nomina Nomina { get; set; }
        public int NominaId { get; set; }


    }
}
