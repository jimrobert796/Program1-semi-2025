using Microsoft.EntityFrameworkCore;
// lo de arriba es el framework de entity framework core

namespace webappacademica.Models
{
    public class MyDbContext : DbContext
    {
        //Constructor
        public MyDbContext()
        {

        }

        // Constructor con la base de datos 
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Docente> Docentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Conectarnos a la tabla alumno
            base.OnModelCreating(modelBuilder);
            //Definir la clave primaria en el modelo
            modelBuilder.Entity<Alumno>().HasKey(a => a.idAlumno);
            modelBuilder.Entity<Materia>().HasKey(a => a.idMateria);
            modelBuilder.Entity<Docente>().HasKey(a => a.idDocente);
        }

    }
}
