using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.Nombre = "D";
            escuela.AñoDeCreación = 2005;
            escuela.Ciudad = "Popayan";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Si";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.UniqueId = Guid.NewGuid().ToString();
            return View(escuela);
        }
    }
}
