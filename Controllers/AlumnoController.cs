﻿using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class AlumnoController : Controller
    {
        /*
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{AlumnoId}")]
        */
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var a = from alum in _context.Alumnos where alum.Id == id select alum;
                return View(a.SingleOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }

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
