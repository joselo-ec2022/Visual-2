using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_contador.Entidad
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }

        public Sueldo sueldos { get; set; }
        public int SueldoId { get; set; }


        // referencia con cargo

        public Cargo Cargo { get; set; }
        public int CargoId { get; set; } 

        
        // referencia a sueldo

        public Sueldo Sueldo { get; set; }

        public List<Sueldo> Sueldos { get; set; }

    }
}
