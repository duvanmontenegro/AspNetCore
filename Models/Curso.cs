using System;
using System.Collections.Generic;

namespace AspNetCore.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        //Hijos
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        public string Dirección { get; set; }
        //Padre
        public string EscuelaId { get; set; } //Crea relacion con el padre:EscuelaId es convencion 
        public Escuela Escuela { get; set; }
    }
}