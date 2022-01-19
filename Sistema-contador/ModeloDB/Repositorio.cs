using Microsoft.EntityFrameworkCore;
using Sistema_contador.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDB
{
    public class Repositorio: DbContext
    {
        //configuracion de las entidades
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cargo> Cargo { get; set; }



    }
}
