using ModeloDB;
using Sistema_contador.Entidad;
using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado Pedro = new Empleado() {
            
                Nombres = "Pedro Hugo", 
                Apellidos = "Saltos Ruales",
                Cedula = "010348574",
                Direccion = "Quito", 
                Telefono = "09326732",
                Email = "pedro@g.com"  };

            // cargo con sueldo
            Cargo Analista = new Cargo()
            {
                tipo_departamento = "tic",
                nombre_cargo = "empleado",
                tipo_funcion = "sistemas"

            };

            //Sueldo
            Sueldo Sueldo_analista = new Sueldo()
            {
              
                sueldo_estipulado = 500.50,
                estado_sueldo = false,
                fecha_pago = new DateTime(2021, 01, 11)
                
            };

            //nomina
            Nomina nomina_analistas = new Nomina()
            {
                Empleado = Pedro,
                Cargo = Analista,
                Sueldo = Sueldo_analista

            };

            ListadoDB db = new ListadoDB();
            db.Nomina.Add(nomina_analistas);
            db.SaveChanges();

        }
    }
}
