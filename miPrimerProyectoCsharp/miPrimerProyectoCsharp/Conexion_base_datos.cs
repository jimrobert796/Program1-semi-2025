using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; // libreria que permite comandos para trabajar con bases de datos

using System.Data.SqlClient; // libreria que permiete trabajar con SQL Server

namespace miPrimerProyectoCsharp
{
    internal class Conexion_base_datos
    {
        // definir atributos metodos de la clase.

        public SqlConnection objConexion = new SqlConnection(); // Conectarme a la base de datos o BD
        SqlCommand objComando = new SqlCommand(); // ejecutar SQL en base de datos. Lectura , escritura, actualizacion, eliminacion, intercecion etc
        public SqlDataAdapter objAdaptadir = new SqlDataAdapter(); // un puente entre la BD y la aplicacion. Imagina por donde pasan los datos a la aplicacion
        DataSet objDs = new DataSet(); // Es una representacion de arquitectura de la BD en memoria


        // CONSTRUCTOR
        // Constructor si es que se llama igual que la clase -> inicializador de los atributos 
        public Conexion_base_datos()
        {
            // Poner arroba @ siempre ya que no dara problemas con las barras invertidas
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\usuarios.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // abrir la conexion a la BD

        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); // limpiar el dataset
            objComando.Connection = objConexion; // establecer conexion para comandos 

            objAdaptadir.SelectCommand = objComando; // Establecer el comando de la seleccion 


            objComando.CommandText = "SELECT * FROM usuarios";
            objAdaptadir.Fill(objDs, "usuarios");

            return objDs;

        }
        public string mantenimiento_usuarios(string[] datos, string accion)
        {

            // string[] datos = { idUsuario, usuario ,clave, nombre, direccion, telefono };

            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO usuarios (usuario, clave, nombre, direccion, telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "','" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE usuarios SET usuario='" + datos[1] + "', clave='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5] + "' WHERE idUsuario='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE FROM usuarios WHERE idUsuario=" + datos[0];
            }
            else if (accion == "Verificar")
            {
                sql = "Select from usuarios WHERE idUsuario='" + datos[0] + "' AND clave='"+ datos[1]+ "'";
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
    }
}
