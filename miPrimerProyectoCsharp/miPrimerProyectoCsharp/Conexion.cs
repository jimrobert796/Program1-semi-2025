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

        SqlConnection objConexion = new SqlConnection(); // Conectarme a la base de datos o BD
        SqlCommand objComando = new SqlCommand(); // ejecutar SQL en base de datos. Lectura , escritura, actualizacion, eliminacion, intercecion etc
        SqlDataAdapter objAdaptadir = new SqlDataAdapter(); // un puente entre la BD y la aplicacion. Imagina por donde pasan los datos a la aplicacion
        DataSet objDs = new DataSet(); // Es una representacion de arquitectura de la BD en memoria


        // CONSTRUCTOR
        // Constructor si es que se llama igual que la clase -> inicializador de los atributos 
        public Conexion()
        {
            // Poner arroba @ siempre ya que no dara problemas con las barras invertidas
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // abrir la conexion a la BD

        }
        // Metodo para obtener los datos de la BD y devolverlos en un DataSet
        public DataSet obtenerDatos()
        {
            objDs.Clear(); // limpiar el dataset
            objComando.Connection = objConexion; // establecer conexion para comandos 

            objAdaptadir.SelectCommand = objComando; // Establecer el comando de la seleccion 

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptadir.Fill(objDs, "alumnos"); // Tomando los datos de la BD y llenando el Dataset

            return objDs;


        }
        // Guardado de datos 
        public string administrarDatos(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
            }
            return ejecturaSql(sql, datos);
        }

        public string ejecturaSql(string sql, string[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear(); // Limpiar los parametros anteriores
                objComando.Parameters.AddWithValue("@idAlumno", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString(); // Ejecutar el comando y devolver el numero de filas afectadas
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
