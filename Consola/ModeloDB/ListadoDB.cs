using Microsoft.EntityFrameworkCore;
using Sistema_contador.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDB
{
    public class ListadoDB: DbContext
    {
        //configuracion de las entidades
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cargo> Cargo { get; set; }

        public DbSet<Aportes> Aportes { get; set; }
        public DbSet<Sueldo> Sueldo { get; set; }

        public DbSet<Nomina> Nomina { get; set; }
        public DbSet<Sueldo_final> Sueldo_final { get; set; }

        //----------------------------Sobreescribimos---------------------------------
        
        //Configuramos la conexion de la BD


       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sistema de gestion tributaria = SGT
            optionsBuilder.UseSqlServer("Server=DESKTOP-D9M3GKJ; Initial Catalog=SGT; trusted_connection = true;");

        }



        //configuramos el modelo de objeto
        

        
        protected override void OnModelCreating(ModelBuilder model)
        {
            // --- Uno a muchos 
            model.Entity<Cargo>()
                .HasOne(empleado => empleado.Cargo)
                .WithMany(cargo => cargo.Empleado)
                .HasForeingKey(empleado => empleado.SueldoId);

            model.Entity<Aportes>()
                .HasOne(sueldo_final => sueldo_final.Aportes)
                .WithMany(aportes => aportes.Sueldo_final)
                .HasForeingKey(Sueldo_final => sueldo_final.AportesId);

            // --- Uno a uno

            // --- Empleado - Sueldo ---
            model.Entity<Sueldo>()
                .HasOne(sueldo => sueldo.Empleado)
                .WithOne(empleado => empleado.Sueldo)
                .HasForeingKey<Sueldo>(sueldo => sueldo.empleadoId);


            model.Entity<Nomina>()
              .HasOne(cargo => cargo.Nomina)
              .WithOne(nomina => nomina.Cargo)
              .HasForeingKey<Sueldo>(cargo => cargo.NominaId);


            model.Entity<Sueldo_final>()
             .HasOne(sueldo_final => sueldo_final.Aportes)
             .WithOne(aportes => aportes.Sueldo_final)
             .HasForeingKey<Sueldo>(sueldo_final => sueldo_final.AportesId);


            // --- Tabla foreing keys

            model.Entity<Descuentos>()
           .HasKey(descuentos => new
           { descuentos.NominaId,
              descuentos.AportesId });




        }











    }
}
