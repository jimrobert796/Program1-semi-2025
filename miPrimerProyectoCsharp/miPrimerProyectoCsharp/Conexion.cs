using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data; // librería para trabajar con bases de datos
using System.Data.SqlClient;
using System.Windows.Forms; // librería para trabajar con SQL Server

// CONEXION A BASE DE DATOS
namespace miPrimerProyectoCsharp
{
    // clase para la conexion
    internal class Conexion
    {
        // definir atributos metodos de la clase.


        SqlConnection objConexion = new SqlConnection(); // Para la conexion a la base de datos CONEXION
        SqlCommand objComando = new SqlCommand(); // para los comando SQL COMANDOS
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); // para el puente entre la BD y la aplicacion PUENTE
        DataSet objDb = new DataSet(); // para la representacion de la BD en memoria BD EN MEMORIA

        //SqlConnection objConexion = new SqlConnection(); // Conectarme a la base de datos o BD
        //SqlCommand objComando = new SqlCommand(); // ejecutar SQL en base de datos. Lectura , escritura, actualizacion, eliminacion, intercecion etc
        //SqlDataAdapter objAdaptadir = new SqlDataAdapter(); // un puente entre la BD y la aplicacion. Imagina por donde pasan los datos a la aplicacion
        //DataSet objDs = new DataSet(); // Es una representacion de arquitectura de la BD en memoria

        // CONSTRUCTOR
        public Conexion()
        {   // usar @ si se quiere que sea string y no ruta dependera de ti
            String cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_academicaDocentes.mdf;Integrated Security=True"; // variable para la cadena de conexion
            objConexion.ConnectionString = cadenaConexion; // cadena de conexion a la base de datos
            objConexion.Open(); // abrir la conexion
        }

        // Obtener los datos mediante un dataset
        public DataSet ObtenerDatos()
        {
            try
            {
                objDb.Clear(); // limpiar el dataset
                objComando.Connection = objConexion; // asignar la conexion al comando

                objAdaptador.SelectCommand = objComando; // asignar el comando al adaptador

                objComando.CommandText = "SELECT * FROM docentes"; // asignar el comando SQL al comando
                objAdaptador.Fill(objDb, "docentes");
                return objDb; // retornar el dataset
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
                return null;

            }
        }
        // Encargada de los comando a usar
        public string administrarDatos(string[] datos, string accion)
        {
            string sql = "";

            if (accion == "Nuevo")
            {
                sql = "INSERT INTO docentes (codigo, materia, nombre, direccion, telefono) VALUES  (@codigo, @materia, @nombre, @direccion, @telefono)";
            }
            if (accion == "Modificar")
            {
                sql = "UPDATE docentes SET codigo=@codigo, materia=@materia, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE IdDocentes = @IdDocentes";
            }
            if (accion == "Eliminar")
            {
                sql = "DELETE FROM docentes WHERE IdDocentes = @IdDocentes";
            }
            return ejecutarSQL(sql, datos);
        }

        public string ejecutarSQL(string sql, string[] datos)
        {
            objComando.Connection = objConexion;
            objComando.CommandText = sql;

            try
            {
                objComando.Parameters.Clear(); // limpiar siempre lo que se envia

                //SE le pide agregar el valor segun el comando y lo que esta en tanto lo que se va a hacer y lo que esta en la BD
                objComando.Parameters.AddWithValue("@IdDocentes", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@materia", datos[2]);
                objComando.Parameters.AddWithValue("@nombre", datos[3]);
                objComando.Parameters.AddWithValue("@direccion", datos[4]);
                objComando.Parameters.AddWithValue("@telefono", datos[5]);

                return objComando.ExecuteNonQuery().ToString(); //DEVUELVE EL NUMERO DE FILAS AFECTADAS 
                // PARA SABER SI HIZO LO CORRECTO

            }
            catch (Exception ex)
            {
                return ex.Message;  // Devuelve vacio si algo va mal
            }
            
        }
        
    }
}
