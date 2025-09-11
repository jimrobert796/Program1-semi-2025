using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; // libreria que permite comandos para trabajar con bases de datos
using System.Data.SqlClient; // libreria que permiete trabajar con SQL Server

namespace miPrimerProyectoCsharp
{
    internal class Conexion
    {
        // definir atributos metodos de la clase.

        SqlConnection objConexion = new SqlConnection(); // Conectarme a la base de datos o BD
        SqlCommand objComando = new SqlCommand(); // ejecutar SQL en base de datos. Lectura , escritura, actualizacion, eliminacion, intercecion etc
        SqlDataAdapter objAdaptadir = new SqlDataAdapter(); // un puente entre la BD y la aplicacion. Imagina por donde pasan los datos a la aplicacion
        DataSet objDs = new DataSet(); // Es una representacion de arquitectura de la BD en memoria


        // Constructor si es que se llama igual que la clase -> inicializador de los atributos 
        public Conexion()
        {
            string cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // abrir la conexion a la BD

        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); // limpiar el dataset
            objComando.Connection = objConexion; // establecer conexion para comandos 

            objAdaptadir.SelectCommand = objComando; // Establecer el comando de la seleccion 

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptadir.Fill(objDs, "alumnos"); // Tomando los datos de la BD y llenando el Dataset

            return objDs;

        }


    }
}
