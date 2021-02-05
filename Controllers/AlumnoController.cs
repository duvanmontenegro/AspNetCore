using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAlumno", _context.Alumnos);
        }
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext contex)
        {
            _context = contex;
        }
    }
}
