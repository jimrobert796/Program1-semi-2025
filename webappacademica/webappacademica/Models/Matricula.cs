using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappacademica.Models
{
    public class Matricula
    {
        [Key]
        public int idMatricula {  get; set; }
        public int idAlumno {  get; set; } // llave foranea
        public int idPeriodo {  get; set; } // llave foranea

        public DateTime fecha { get; set; }

        // relacion con la tabla alumnos 
        [ForeignKey("idAlumno")]
        public Alumno? Alumno { get; set; }

        // relacion con la tabla periodos
        [ForeignKey("idPeriodo")]
        public Periodo? Periodo { get; set; }

    }
}
