using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura()
        {
           
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura", _context.Asignaturas);
        }
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext contex)
        {
            _context = contex;
        }
    }
}
