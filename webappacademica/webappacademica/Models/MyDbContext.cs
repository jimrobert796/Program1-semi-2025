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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Conectarnos a la tabla alumno
            base.OnModelCreating(modelBuilder);
            //Definir la clave primaria en el modelo
            modelBuilder.Entity<Alumno>().HasKey(a => a.idAlumno);
        }

    }
}
