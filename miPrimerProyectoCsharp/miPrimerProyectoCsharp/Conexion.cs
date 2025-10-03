using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; // libreria que permite comandos para trabajar con bases de datos

using System.Data.SqlClient; // libreria que permiete trabajar con SQL Server

namespace miPrimerProyectoCsharp
{

    // Clase que se encara de la conexion con las base de datos SQL Server
    internal class Conexion
    {
        // definir atributos metodos de la clase.

        public SqlConnection objConexion = new SqlConnection(); // Conectarme a la base de datos o BD
        SqlCommand objComando = new SqlCommand(); // ejecutar SQL en base de datos. Lectura , escritura, actualizacion, eliminacion, intercecion etc
        public SqlDataAdapter objAdaptadir = new SqlDataAdapter(); // un puente entre la BD y la aplicacion. Imagina por donde pasan los datos a la aplicacion
        DataSet objDs = new DataSet(); // Es una representacion de arquitectura de la BD en memoria


        // CONSTRUCTOR
        // Constructor si es que se llama igual que la clase -> inicializador de los atributos 
        public Conexion()
        {
            // Poner arroba @ siempre ya que no dara problemas con las barras invertidas
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // abrir la conexion a la BD

        }

        // Metodo para obtener los datos de la BD y devolverlos en un DataSet
        public DataSet obtenerDatos()
        {
            objDs.Clear(); // limpiar el dataset
            objComando.Connection = objConexion; // establecer conexion para comandos 

            objAdaptadir.SelectCommand = objComando; // Establecer el comando de la seleccion 

            //Para la tabla alumnos
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptadir.Fill(objDs, "alumnos"); // Tomando los datos de la BD y llenando el Dataset

            //Para la tabla materias
            objComando.CommandText = "SELECT * FROM materias";
            objAdaptadir.Fill(objDs, "materias"); // Tomando los datos de la BD y llenando el Dataset

            //Para la tabla materias
            objComando.CommandText = "SELECT * FROM docentes";
            objAdaptadir.Fill(objDs, "docentes"); // Tomando los datos de la BD y llenando el Dataset

     


            objAdaptadir.Fill(objDs, "docentes"); // Tomando los datos de la BD y llenando el Dataset

            return objDs;

        } 

        // Guardado de datos para alumnos
        public string administrarDatosAlumnos(string[] datos, string accion)
        {

            // string[] datos = { idAlumno, codigo, nombre, direccion, telefono };

            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "','" + datos[4] + "')";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecturaSql(sql);
        }

        // Guardado de datos para materias 
        public string administrarDatosMaterias(string[] datos, string accion)
        {
            // string[] datos = { idMateria, codigo, nombre, uv };
            // lo que se hace es concatenacion

            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO materias (codigo, nombre, uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] +"')";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + datos[0] + "'";
            }
            return ejecturaSql(sql);
        }

        // Guardado de datos para docentes
        public string administrarDatosDocentes(string[] datos, string accion)
        {

            // string[] datos = { idAlumno, codigo, nombre, direccion, telefono };

            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO docentes (codigo, nombre, materia, dui, direccion, telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE docentes SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', materia='" + datos[3] + "', dui='" + datos[4] + "', direccion= '" + datos[5] +"', telefono= '" + datos[6] +"' WHERE idDocente='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocente='" + datos[0] + "'";
            }
            return ejecturaSql(sql);
        }


        public string ejecturaSql(string sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql; // ejecutar el comando sql que se armo anteriormente

                return objComando.ExecuteNonQuery().ToString(); // Ejecutar el comando y devolver el numero de filas afectadas
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        //UNICAMENTE PARA ALUMNOS 

        
    }
}
