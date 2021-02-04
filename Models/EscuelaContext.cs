using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    //Contexto de base de datos en memoria virtual
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //HasData=trabaja con array
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();
            escuela.Nombre = "D";
            escuela.AñoDeCreación = 2005;
            escuela.Ciudad = "Popayan";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Si";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Id = Guid.NewGuid().ToString();
            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Asignatura>().HasData(
                            new Asignatura{Nombre="Matemáticas",Id=Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física",Id=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano",Id=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales",Id=Guid.NewGuid().ToString()}
                );
            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());
        }
        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}", Id = Guid.NewGuid().ToString() };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }
    }
}
