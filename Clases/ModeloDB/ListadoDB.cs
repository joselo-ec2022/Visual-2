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


        //Configuramos la conexion de la BD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sistema de gestion tributaria = SGT
            optionsBuilder.UseSqlServer("Server=DESKTOP-D9M3GKJ; Initial Catalog=SGT; trusted_connection = true;");



        }
    }
}
