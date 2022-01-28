using Microsoft.EntityFrameworkCore;
using Sistema_contador.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDB
{
    public class ListadoDB: DbContext
    {
        public ListadoDB()
        {
        }

        public ListadoDB(DbContextOptions<ListadoDB> options)
        
            :base(options)
        {

        }
        


        //configuracion de las entidades
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<Cargo> cargos { get; set; }

        public DbSet<Aportes> aportes { get; set; }
        public DbSet<Sueldo> sueldos { get; set; }

        public DbSet<Nomina> nominas { get; set; }
        public DbSet<Sueldo_final> sueldo_finales { get; set; }

        //----------------------------Sobreescribimos---------------------------------

        //Configuramos la conexion de la BD



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //sistema de gestion tributaria = SGT
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-D9M3GKJ; Initial Catalog=SGT; trusted_connection = true;");
           

        //}



        //configuramos el modelo de objeto
        

        
        protected override void OnModelCreating(ModelBuilder model)
        {
            // --- Uno a muchos 

            //--- Un cargo tiene muchos empleados
            model.Entity<Empleado>()
                .HasOne(empleado => empleado.Cargo)
                .WithMany(cargo => cargo.Empleado)
                .HasForeignKey(empleado => empleado.CargoId);

            //--- Un sueldo final tiene muchos aportes
            model.Entity<Aportes>()
                .HasOne(aportes => aportes.Sueldo_final)
                .WithMany(sueldo_final => sueldo_final.Aportes)
                .HasForeignKey(aportes => aportes.Sueldo_finalId);


            //model.Entity<Sueldo>()
            // .HasOne(sueldo => sueldo.Nomina)
            // .WithMany(nomina => nomina.Sueldo)
            // .HasForeignKey(sueldo => sueldo.NominaId);




            // --- Uno a uno

            // --- Empleado - Sueldo ---
            model.Entity<Empleado>()
                .HasOne(empleado => empleado.Sueldo)
                .WithOne(sueldo => sueldo.Empleado)
                .HasForeignKey<Sueldo>(sueldo => sueldo.EmpleadoId);


            // --- Nomina - Cargo ---
            //model.Entity<Nomina>()
            //  .HasOne(nomina => nomina.Cargo)
            //  .WithOne(cargo => cargo.Nomina)
            //  .HasForeignKey<Cargo>(cargo => cargo.NominaId);

           


            // --- Empleado - Sueldo_final

            //model.Entity<Empleado>()
            //  .HasOne(empleado => empleado.Sueldo_final)
            //  .WithOne(sueldo_final => sueldo_final.Empleado)
            //  .HasForeignKey<Sueldo_final>(sueldo_final => sueldo_final.EmpleadoId);


            // --- Tabla foreing keys

            model.Entity<Descuentos>()
           .HasKey(descuentos => new
           { descuentos.NominaId,
              descuentos.AportesId });


            //  NO ACCION 
            model.Entity<Empleado>()
              .HasOne(empleado => empleado.Cargo)
              .WithMany(cargo => cargo.Empleado)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(empleado => empleado.CargoId);


            //model.Entity<Sueldo>()
            //  .HasOne(sueldo => sueldo.Empleado)
            //  .WithMany(empleado => empleado.Sueldos)
            //  .OnDelete(DeleteBehavior.NoAction)
            //  .HasForeignKey(sueldo => sueldo.EmpleadoId);



            //    model.Entity<Nomina>()
            //.HasOne(nomina => nomina.Sueldo)
            //.WithOne(sueldo => sueldo.Nomina)
            //.OnDelete(DeleteBehavior.NoAction);





        }











    }
}
