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
            var asignaturas = new Asignatura(){
                Nombre="Programación",UniqueId=Guid.NewGuid().ToString()
            };
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View(asignaturas);
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas",UniqueId=Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física",UniqueId=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano",UniqueId=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales",UniqueId=Guid.NewGuid().ToString()}
                };
            ViewBag.CosaDinamica = "algo";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}
