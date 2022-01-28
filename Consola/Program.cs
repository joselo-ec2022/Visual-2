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
                //Empleado = Pedro,
                //Cargo = Analista,
               // Sueldo = Sueldo_analista

            };


            //nomina
            Aportes aportes_dados = new Aportes()
            {
                aporte_patronal_dado = 50.40,
                aporte_personal_dado = 50.90,
                tiempo_aportado = 1

            };



            Sueldo_final sueldo_final = new Sueldo_final()
            {
                sueldo_base = 500.00,
                sueldo_descontado = 95.50,
                tipo_decimo = "anual",
                sueldo_recibido = 404.50,
                sueldo_anual_final = 4854.00,
                total_decimo_recibido = 950

            };


            ListadoDB db = new ListadoDB();
            db.nominas.Add(nomina_analistas);
            db.SaveChanges();

        }
    }
}
