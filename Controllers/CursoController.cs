﻿using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class CursoController : Controller
    {
        /*
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{AlumnoId}")]
        */
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var a = from cur in _context.Cursos where cur.Id == id select cur;
                return View(a.SingleOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }

        }
        public IActionResult MultiCurso()
        {
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiCurso", _context.Cursos);
        }
        private EscuelaContext _context;
        public CursoController(EscuelaContext contex)
        {
            _context = contex;
        }
    }
}
