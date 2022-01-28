using Microsoft.AspNetCore.Mvc;
using ModeloDB;
using Sistema_contador.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSGT.Controllers
{
    public class UsuariosController1 : Controller
    {
        
            private readonly ListadoDB db;

        public UsuariosController1(ListadoDB db)
        {
            this.db = db;
        }


        // recupera la lista y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Empleado> Empleados = db.empleados;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Edit()
        {
            return View();
        }


        public IActionResult Delete()
        {
            return View();
        }

    }
}
