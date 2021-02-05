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
            /*
            var escuela = new Escuela();
            escuela.Nombre = "D";
            escuela.AñoDeCreación = 2005;
            escuela.Ciudad = "Popayan";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Si";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Id = Guid.NewGuid().ToString();
            */
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext contex)
        {
            _context = contex;
        }
    }
}
