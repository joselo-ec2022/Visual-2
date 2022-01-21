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
        public List<Empleado> Trabajadores { get; set; }

        public Empleado Empleado { get; set; }

        public int EmpleadoId { get; set; }
    }
}
