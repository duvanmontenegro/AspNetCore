using System;
using System.Collections.Generic;

namespace AspNetCore.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId { get; set; } //Crea relacion con el padre:EscuelaId es convencion 
        public Curso Curso { get; set; }
        public List<Evaluaci�n> Evaluaciones { get; set; }// = new List<Evaluaci�n>();
    }
}